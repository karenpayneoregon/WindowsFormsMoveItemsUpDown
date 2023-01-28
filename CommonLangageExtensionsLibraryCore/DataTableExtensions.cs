using System.Data;

namespace CommonLangageExtensionsLibraryCore;

public static class DataTableExtensions
{
    /// <summary>
    /// Reorder field RowPosition
    /// </summary>
    /// <param name="sender"></param>
    /// <remarks>
    /// This is the same logic found in Operations.cs update method.
    /// So you can use this or the for/next in Operations.UpdateProductTable
    /// </remarks>
    public static void ReorderPositionMarker(this DataTable sender)
    {
        if (sender.Columns.Contains("RowPosition"))
        {
            int indexer = 0;
            for (int index = 0; index < sender.Rows.Count - 1; index++)
            {
                sender.Rows[index].SetField("RowPosition", indexer);
                indexer += 1;
            }
        }
    }
    /// <summary>
    /// Reorder field by specific field name
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="pFieldName">Field name to reposition by</param>
    /// <remarks>
    /// This is the same logic found in Operations.cs update method.
    /// So you can use this or the for/next in Operations.UpdateProductTable
    /// </remarks>
    public static void ReorderPositionMarker(this DataTable sender, string pFieldName)
    {
        if (sender.Columns.Contains(pFieldName))
        {
            int indexer = 0;
            for (int index = 0; index < sender.Rows.Count - 1; index++)
            {
                sender.Rows[index].SetField(pFieldName, indexer);
                indexer += 1;
            }
        }
    }
}