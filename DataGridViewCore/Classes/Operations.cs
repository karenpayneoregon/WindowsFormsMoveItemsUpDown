using System.Data;
using Microsoft.Data.SqlClient;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace DataGridViewCore.Classes;

public class Operations 
{
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

    /// <summary>
    /// Get current row count for category table
    /// </summary>
    public (bool success, int count, Exception exception) CategoryCount
    {
        get
        {

            var selectStatement = "SELECT COUNT(Id) FROM dbo.Categories";

            using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
            using var cmd = new SqlCommand() { Connection = cn };

            cmd.CommandText = selectStatement;
            try
            {
                cn.Open();
                //return (int)cmd.ExecuteScalar();
                return (true,(int)cmd.ExecuteScalar(), null)!;
            }
            catch (Exception ex)
            {
                return (false, 0, ex);
            }
        }

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
            
        _categoryIdentifier = pCategoryIdentifier;

        var dt = new DataTable();
   

        //
        // Note the field to use for positioning rows is dynamic based on the name provided
        // in the constructor.
        //
        var selectStatement = $"SELECT ProductID,ProductName,CategoryID,{KeyPositionFieldName} " +
                              "FROM dbo.Products WHERE CategoryID = @CategoryID " +
                              $"ORDER BY {KeyPositionFieldName}";


        using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
        using var cmd = new SqlCommand() { Connection = cn };
        //cmd.Parameters.AddWithValue("@CategoryID", pCategoryIdentifier);
        cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = _categoryIdentifier;
        cmd.CommandText = selectStatement;
        cn.Open();
        dt.Load(cmd.ExecuteReader());

        return dt;
    }

    /// <summary>
    /// Update row position field in product table
    /// </summary>
    /// <param name="pDataTable"></param>
    /// <returns></returns>
    public void UpdateProductTable(DataTable pDataTable)
    {


        var selectStatement = $"UPDATE dbo.Products SET {KeyPositionFieldName} =" +
                              $" @{KeyPositionFieldName} WHERE ProductID = @ProductId";


        using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
        using var cmd = new SqlCommand() { Connection = cn };

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

        cn.Open();

        // used to give new row position
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
}