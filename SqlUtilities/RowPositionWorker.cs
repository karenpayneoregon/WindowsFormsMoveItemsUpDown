using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataConnections;
using SqlUtilities.ConcreteClasses;

namespace SqlUtilities
{
    public class RowPositionWorker : BaseSqlServerConnection
    {
        /// <summary>
        /// You want to add the capability to perform up/down operations in
        /// a windows desktop app where prior to this there was no field
        /// to store the row position. 
        /// 
        /// First add a new int field named RowPosition then mimic the
        /// code below in ProductTable method. In the case of Product table
        /// there is a relationship to the Categories table so we must
        /// increment on each category, not the entire table as we want
        /// to show one category at a time to the user.
        /// </summary>
        public RowPositionWorker()
        {
            DefaultCatalog = "OrderingRows";
        }
        /// <summary>
        /// Pass in default catalog
        /// </summary>
        /// <param name="pDefaultCatalog"></param>
        public RowPositionWorker(string pDefaultCatalog)
        {
            DefaultCatalog = pDefaultCatalog;
        }

        public List<int> CategoryIdentifiers()
        {
            var idList = new List<int>();
            var selectStatement = "SELECT DISTINCT CategoryID FROM dbo.Categories ";

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = selectStatement;
                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idList.Add(reader.GetInt32(0));
                    }

                }
            }

            return idList;
        }

        public bool RigSuppliersTable()
        {
            mHasException = false;
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = 
                        "IF EXISTS  (SELECT * FROM INFORMATION_SCHEMA.COLUMNS " + 
                        "WHERE table_name = 'Suppliers'  " + 
                        "AND column_name = 'RowPosition') BEGIN " +
                        "ALTER TABLE Suppliers DROP COLUMN RowPosition END";

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "ALTER TABLE OrderingRows.dbo.Suppliers ADD [RowPosition] [INT] NULL";
                        cmd.ExecuteNonQuery();

                        cmd.Parameters.AddWithValue("@MaxSurrogateKey", 0);
                        cmd.CommandText = "UPDATE  dbo.Suppliers " + 
                                          "SET @MaxSurrogateKey = RowPosition = @MaxSurrogateKey + 1 " + 
                                           "WHERE   RowPosition IS NULL; ";

                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return IsSuccessFul;
        }

        /// <summary>
        /// This method is for setting RowPosition for a specific category which
        /// is needed after adding this field to the product table. 
        /// 
        /// This assumes product table started prior to implementing rows up/down
        /// and that the postion field has been added to the table.
        /// </summary>
        /// <param name="pCategoryIdentifier"></param>
        /// <returns></returns>
        public bool ProductTable(int pCategoryIdentifier)
        {
            mHasException = false;

            var selectStatement = "SELECT ProductID,CategoryID,RowPosition " + 
                                  "FROM dbo.Products WHERE CategoryID = @CategoryID " +
                                  "ORDER BY CategoryID, ProductName";

            var updateStatement = "UPDATE dbo.Products " +
                                  "SET RowPosition = @RowPosition " + 
                                  "WHERE ProductID = @ProductId";

            var productList = new List<Product>();

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = selectStatement;
                    cmd.Parameters.AddWithValue("@CategoryID", pCategoryIdentifier);

                    try
                    {
                        cn.Open();

                        var reader = cmd.ExecuteReader();
                        var counter = 0;

                        while (reader.Read())
                        {
                            productList.Add(new Product()
                            {
                                ProductID = reader.GetInt32(0),
                                CategoryID = pCategoryIdentifier,
                                RowPosition = counter
                            });

                            counter += 1;
                        }

                        reader.Close();

                        cmd.Parameters.Clear();

                        cmd.CommandText = updateStatement;

                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = "@ProductId",
                            SqlDbType = SqlDbType.Int
                        });

                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = "@RowPosition",
                            SqlDbType = SqlDbType.Int
                        });
                        for (int index = 0; index < productList.Count; index++)
                        {
                            cmd.Parameters["@ProductId"].Value = productList[index].ProductID;
                            cmd.Parameters["@RowPosition"].Value = productList[index].RowPosition;
                            cmd.ExecuteNonQuery();
                        }

                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                        return false;
                    }

                }
            }

            return true;
        }
    }
}
