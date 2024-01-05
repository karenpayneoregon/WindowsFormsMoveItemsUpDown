namespace DataGridViewCore.Models;

public class RowItem
{
    /// <summary>
    /// Matches the database table column name
    /// </summary>
    public int RowPosition { get; }
    /// <summary>
    /// Primary key in the Products table
    /// </summary>
    public int ProductId { get; }

    public RowItem(int rowPosition, int productId)
    {
        RowPosition = rowPosition;
        ProductId = productId;
    }
}