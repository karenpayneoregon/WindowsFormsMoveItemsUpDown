using System;

using System.Data;
using System.Data.SqlClient;


namespace ListBoxOnly.Classes
{
    public class Operations
    {

        public string ConnectionString => 
            "Data Source=.\\SQLEXPRESS;Initial Catalog=OrderingRows1;Integrated Security=True";

        /// <summary>
        /// Set up default category for the sql-server database
        /// Set the field used to update row position in a table.
        /// </summary>
        /// <param name="pKeyPositionFieldName"></param>
        public Operations(string pKeyPositionFieldName = "RowPosition")
        {
            KeyPositionFieldName = pKeyPositionFieldName;
        }

        /// <summary>
        /// Field responsible for remembering position
        /// </summary>
        public string KeyPositionFieldName { get; set; }
        private int _categoryIdentifier;

        public (DataTable table, Exception exception) LoadProductsByCategoryId(int pCategoryIdentifier)
        {

            _categoryIdentifier = pCategoryIdentifier;

            var dt = new DataTable();


            //
            // Note the field to use for positioning rows is dynamic based on the name provided
            // in the constructor.
            //
            var selectStatement = 
                $"SELECT ProductID,ProductName,CategoryID,{KeyPositionFieldName} " + 
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
                        return (null, e);
                    }
                }
            }

            return (dt, null);
        }

        /// <summary>
        /// Update row position field in product table
        /// </summary>
        /// <param name="pDataTable"></param>
        /// <returns></returns>
        public (bool success, Exception exception) UpdateProductTable(DataTable pDataTable)
        {

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

                        // used to give new row position
                        int newPosition = 0;

                        for (var rowIndex = 0; rowIndex < pDataTable.Rows.Count; rowIndex++)
                        {
                            // set new row position
                            cmd.Parameters[$"@{KeyPositionFieldName}"].Value = newPosition;

                            cmd.Parameters["@ProductId"].Value =
                                pDataTable.Rows[rowIndex].Field<int>("ProductId");

                            //cmd.ExecuteNonQuery();
                            Console.WriteLine(cmd.ExecuteNonQuery());
                            newPosition += 1;
                        }

                    }
                    catch (Exception e)
                    {
                        return (false, e);
                    }
                }
            }

            return (true, null);

        }
    }
}
