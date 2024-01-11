namespace DataGridViewCore.Classes;
public class SqlStatements
{
    public static string SelectCategoryByRowPosition => 
        """
        SELECT ProductID,ProductName,CategoryID,RowPosition
        FROM dbo.Products
        WHERE CategoryID = @CategoryID
        ORDER BY RowPosition
        """;

    public static string UpdateProduct => 
        """
        UPDATE dbo.Products
        SET RowPosition = @RowPosition
        WHERE ProductID = @ProductId
        """;
}
