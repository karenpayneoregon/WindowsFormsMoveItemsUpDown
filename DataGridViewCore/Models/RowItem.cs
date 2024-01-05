namespace DataGridViewCore.Models;

public class RowItem
{
    public int RowPosition { get; }
    public int ProductId { get; }

    public RowItem(int rowPosition, int productId)
    {
        RowPosition = rowPosition;
        ProductId = productId;
    }
}