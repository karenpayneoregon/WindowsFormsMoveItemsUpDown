using System.Data;
using Dapper;
using DataGridViewCore.Models;
using Microsoft.Data.SqlClient;
using static ConfigurationLibrary.Classes.ConfigurationHelper;
// ReSharper disable ForCanBeConvertedToForeach

namespace DataGridViewCore.Classes;

public class Operations
{

    /// <summary>
    /// Load products by category identifier
    /// </summary>
    /// <param name="categoryIdentifier">Category identifier</param>
    /// <returns></returns>
    public DataTable LoadProductsByCategory(int categoryIdentifier)
    {
        var dt = new DataTable();
        using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
        dt.Load(cn.ExecuteReader(SqlStatements.SelectCategoryByRowPosition, new { CategoryID = categoryIdentifier }));
        return dt;
    }

    /// <summary>
    /// Update row position field in product table
    /// </summary>
    /// <param name="container"></param>
    /// <remarks>Marc Gravell (Dapper author) recommendations which slimmed down the code from prior versions</remarks>
    public void UpdateProductTable(List<RowItem> container)
    {
        using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
        cn.Execute(SqlStatements.UpdateProduct, container);
    }
}