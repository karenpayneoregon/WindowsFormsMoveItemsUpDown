﻿using System.Data;
using Dapper;
using DataGridViewCore.Models;
using Microsoft.Data.SqlClient;
using static ConfigurationLibrary.Classes.ConfigurationHelper;
// ReSharper disable ForCanBeConvertedToForeach

namespace DataGridViewCore.Classes;

public class Operations
{

    private int _categoryIdentifier;
    public int CategoryIdentifier => _categoryIdentifier;

    /// <summary>
    /// Load products by category identifier
    /// </summary>
    /// <param name="categoryIdentifier">Category identifier</param>
    /// <returns></returns>
    public DataTable LoadProductsByCategory(int categoryIdentifier)
    {
        _categoryIdentifier = categoryIdentifier;

        var dt = new DataTable();
        var selectStatement =
            """
                  SELECT ProductID,ProductName,CategoryID,RowPosition
                  FROM dbo.Products
                  WHERE CategoryID = @CategoryID
                  ORDER BY RowPosition
                 """;

        using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
        var reader = cn.ExecuteReader(selectStatement, new { CategoryID = categoryIdentifier });

        dt.Load(reader);
        return dt;
    }

    /// <summary>
    /// Update row position field in product table
    /// </summary>
    /// <param name="container"></param>
    /// <remarks>Marc Gravell recommendations which slimmed down the code from prior versions</remarks>
    public void UpdateProductTable(List<RowItem> container)
    {

        var selectStatement =
            """
             UPDATE dbo.Products
             SET RowPosition = @RowPosition
             WHERE ProductID = @ProductId
             """;

        using var cn = new SqlConnection() { ConnectionString = ConnectionString() };
        
        cn.Execute(selectStatement, container);
    }
}