using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnections;

namespace DataBackEnd
{
    public class Operations : BaseSqlServerConnection
    {
        /// <summary>
        /// Set up default category for the sql-server database
        /// Set the field used to update row position in a table.
        /// </summary>
        /// <param name="pKeyPositionFieldName"></param>
        public Operations(string pKeyPositionFieldName = "RowPosition")
        {
            DefaultCatalog = "OrderingRows1";
            KeyPositionFieldName = pKeyPositionFieldName;
        }
        /// <summary>
        /// Field responsible for remembering position
        /// </summary>
        public string KeyPositionFieldName { get; set; }

        /// <summary>
        /// Get current row count for category table
        /// </summary>
        public int CategoryCount
        {
            get
            {

                var selectStatement = "SELECT COUNT(Id) FROM dbo.Categories";

                using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
                {
                    using (var cmd = new SqlCommand() { Connection = cn })
                    {
                        cmd.CommandText = selectStatement;
                        try
                        {
                            cn.Open();
                            return (int)cmd.ExecuteScalar();
                        }
                        catch (Exception ex)
                        {
                            mHasException = true;
                            mLastException = ex;
                            return 0;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// When insering a new record into Products table the RowPosition needs to 
        /// be set. This method provides the last RowPosition, when using to insert
        /// a new product record add 1 to the return value.
        /// </summary>
        /// <param name="pCategoryIdentifier"></param>
        /// <returns></returns>
        public int LastRowPositionForCategory(int pCategoryIdentifier)
        {
            var selectStatement = "SELECT MAX(RowPosition) " + 
                                  "FROM dbo.Products " + 
                                  "WHERE CategoryID = @CategoryId";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = selectStatement;
                    cmd.Parameters.AddWithValue("@CategoryId", pCategoryIdentifier);
                    try
                    {
                        cn.Open();
                        return (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                        return 0;
                    }
                }
            }
        }

        /// <summary>
        /// This method is hard coded to get songs for the Beatles
        /// Sgt Pepper’s Lonely Hearts Club Band album for demoing
        /// moving up/down items in a CheckedListBox.
        /// </summary>
        /// <param name="pArtistIdentifier"></param>
        /// <param name="pAlbumIdentifier"></param>
        /// <returns></returns>
        public List<Song> LoadAlbumSongs(int pArtistIdentifier = 1, int pAlbumIdentifier = 2)
        {
            mHasException = false;
            var songList = new List<Song>();

            var selectStatement =
                "SELECT Artist.id, Songs.Name AS Song, Albums.id AS AlbumId, Songs.id AS SongId " +
                "FROM Artist INNER JOIN Albums ON Artist.id = Albums.ArtistId " +
                "INNER JOIN Songs ON Albums.id = Songs.AlbumId " +
                "WHERE (Albums.id = @AlbumIdentifier) AND (Artist.id = @ArtistIdentifier)";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {

                    cmd.CommandText = selectStatement;
                    cmd.Parameters.AddWithValue("@ArtistIdentifier", pArtistIdentifier);
                    cmd.Parameters.AddWithValue("@AlbumIdentifier", pAlbumIdentifier);

                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        songList.Add(new Song()
                        {
                            id = reader.GetInt32(3),
                            Name = reader.GetString(1),
                            AlbumId = reader.GetInt32(0)
                        });
                    }
                }
            }

            return songList;

        }
        public List<Category> LoadCategories()
        {
            mHasException = false;

            var categoryList = new List<Category>();

            var selectStatement = "SELECT CategoryID ,CategoryName ,Id FROM dbo.Categories";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    try
                    {
                        cmd.CommandText = selectStatement;
                        cn.Open();

                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                categoryList.Add(new Category()
                                {
                                    CategoryID = reader.GetInt32(0),
                                    CategoryName = reader.GetString(1),
                                    id = reader.GetInt32(2)
                                });

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }

                }
            }

            return categoryList;

        }
        /// <summary>
        /// Obtain a random category identifier for
        /// use in LoadProductsByCategory method which
        /// serves two masters, the ListBox form demo
        /// and the bound DataGridView form demo.
        /// </summary>
        /// <returns></returns>
        private int RandomCategoryIdentifier()
        {
            int categoryIdentifier = 0;
            mHasException = false;

            // get a random category identifier
            var categoryIdStatement = "SELECT TOP 1 c.Id " +
                                      "FROM dbo.Categories AS c " +
                                      "ORDER BY NEWID()";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    try
                    {
                        cmd.CommandText = categoryIdStatement;
                        cn.Open();
                        categoryIdentifier = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return categoryIdentifier;

        }


        public List<string> LoadCustomersColumns()
        {
            mHasException = false;
            var columnNames = new List<string>();


            var selectStatement = "SELECT COLUMN_NAME " +
                                  "FROM INFORMATION_SCHEMA.COLUMNS " +
                                  "WHERE TABLE_NAME = N\'Customers\'";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = selectStatement;
                    try
                    {
                        cn.Open();

                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            columnNames.Add(reader.GetString(0));
                        }
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }

            return columnNames;
        }
        public DataTable LoadCustomersByDataTable()
        {
            mHasException = false;

            var dt = new DataTable();
            var selectStatement = $"SELECT {string.Join(",", LoadCustomersColumns().ToArray())} FROM dbo.Customers";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = selectStatement;
                    try
                    {
                        cn.Open();

                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }

            return dt;
        }

        public List<Customer> LoadCustomers()
        {
            mHasException = false;
            var customerList = new List<Customer>();
            var selectStatement = "SELECT TOP 15 CompanyName,ContactName,ContactTitle FROM Customers";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = selectStatement;
                    try
                    {
                        cn.Open();

                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            customerList.Add(new Customer()
                            {
                                CompanyName = reader.GetString(0),
                                ContactName = reader.GetString(1),
                                ContactTitle = reader.GetString(2)
                            });

                        }
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }

            return customerList;
        }

        /// <summary>
        /// <returns></returns>
        /// Load products by random category
        /// </summary>
        /// <param name="pOrder">true to order by CategoryId</param>
        /// <returns></returns>
        public DataTable LoadProductsByCategory(bool pOrder = false)
        {
            var dt = new DataTable();
            mHasException = false;

            // get a random category identifier
            var categoryIdStatement = "SELECT TOP 1 c.Id " +
                                      "FROM dbo.Categories AS c " +
                                      "ORDER BY NEWID()";

            // get product by random category identifier
            var selectStatement = $"SELECT ProductID As Id,ProductName As Name " +
                                  "FROM dbo.Products " +
                                  "WHERE CategoryID = @CategoryID";


            if (pOrder)
            {
                selectStatement = selectStatement + " ORDER BY ProductName";
            }

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {

                    try
                    {
                        cmd.CommandText = categoryIdStatement;
                        cn.Open();

                        // get the random category identifier
                        var categoryIdentifier = (int)cmd.ExecuteScalar();

                        cmd.CommandText = selectStatement;

                        // get product by category identifier
                        cmd.Parameters.AddWithValue("@CategoryID", categoryIdentifier);

                        dt.Load(cmd.ExecuteReader());

                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }

            return dt;
        }

        private int _categoryIdentifier;
        public int CategoryIdentifier => _categoryIdentifier;

        /// <summary>
        /// Load products by category identifier
        /// </summary>
        /// <param name="pCategoryIdentifier">Exists category identifier</param>
        /// <returns></returns>
        public DataTable LoadProductsByCategory(int pCategoryIdentifier)
        {
            if (pCategoryIdentifier == -1)
            {
                pCategoryIdentifier = RandomCategoryIdentifier();
            }

            _categoryIdentifier = pCategoryIdentifier;

            var dt = new DataTable();
            mHasException = false;

            //
            // Note the field to use for positioning rows is dynamic based on the name provided
            // in the constructor.
            //
            var selectStatement = $"SELECT ProductID,ProductName,CategoryID,{KeyPositionFieldName} " +
                                  "FROM dbo.Products WHERE CategoryID = @CategoryID " +
                                  $"ORDER BY {KeyPositionFieldName}";


            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.Parameters.AddWithValue("@CategoryID", pCategoryIdentifier);
                    try
                    {
                        cmd.CommandText = selectStatement;
                        cn.Open();
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return dt;
        }
        /// <summary>
        /// Update row position field in product table
        /// </summary>
        /// <param name="pDataTable"></param>
        /// <returns></returns>
        public bool UpdateProductTable(DataTable pDataTable)
        {
            mHasException = false;

            var selectStatement = $"UPDATE dbo.Products SET {KeyPositionFieldName} =" +
                                    $" @{KeyPositionFieldName} WHERE ProductID = @ProductId";


            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {

                    cmd.CommandText = selectStatement;
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = $"@{KeyPositionFieldName}",
                        SqlDbType = SqlDbType.Int
                    });

                    cmd.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "@ProductId",
                        SqlDbType = SqlDbType.Int
                    });

                    try
                    {

                        cn.Open();

                        // used to give new row postion
                        int newPosition = 0;

                        for (var rowIndex = 0; rowIndex < pDataTable.Rows.Count; rowIndex++)
                        {
                            // set new row position
                            cmd.Parameters[$"@{KeyPositionFieldName}"].Value = newPosition;

                            cmd.Parameters["@ProductId"].Value =
                                pDataTable.Rows[rowIndex].Field<int>("ProductId");

                            cmd.ExecuteNonQuery();
                            newPosition += 1;
                        }

                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return !mHasException;
        }
    }
}
