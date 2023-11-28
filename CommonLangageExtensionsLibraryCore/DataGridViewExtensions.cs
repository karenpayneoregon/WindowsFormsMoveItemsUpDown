using System.Data;
using System.Text.RegularExpressions;

namespace CommonLangageExtensionsLibraryCore;

/// <summary>
/// Methods to move current row up/down
/// </summary>
public static class DataGridViewExtensions
{
    /// <summary>
    /// Move row up for a selected row
    /// </summary>
    /// <param name="pDataGridView"></param>
    public static void MoveRowUp(this DataGridView pDataGridView)
    {
        if (pDataGridView.RowCount > 0)
        {
            if (pDataGridView.SelectedRows.Count > 0)
            {

                int selectedIndex = pDataGridView.SelectedCells[0].OwningRow.Index;

                if (selectedIndex == 0)
                {
                    return;
                }
                DataGridViewRowCollection rows = pDataGridView.Rows;

                // remove the previous row and add it behind the selected row.
                DataGridViewRow prevRow = rows[selectedIndex - 1];
                rows.Remove(prevRow);
                prevRow.Frozen = false;
                rows.Insert(selectedIndex, prevRow);
                pDataGridView.ClearSelection();
                pDataGridView.Rows[selectedIndex - 1].Selected = true;
            }
        }
    }
    /// <summary>
    /// Move row down for a selected row
    /// </summary>
    /// <param name="pDataGridView"></param>
    public static void MoveRowDown(this DataGridView pDataGridView)
    {
        if (pDataGridView.RowCount > 0)
        {
            if (pDataGridView.SelectedRows.Count > 0)
            {
                int rowCount = pDataGridView.Rows.Count;
                int selectedIndex = pDataGridView.SelectedCells[0].OwningRow.Index;

                DataGridViewRowCollection rows = pDataGridView.Rows;

                // remove the next row and add it in front of the selected row.
                DataGridViewRow nextRow = rows[selectedIndex + 1];
                rows.Remove(nextRow);
                nextRow.Frozen = false;
                rows.Insert(selectedIndex, nextRow);
                pDataGridView.ClearSelection();
                pDataGridView.Rows[selectedIndex + 1].Selected = true;
            }
        }
    }
    /// <summary>
    /// Move selected row bound via a BindingSource up/down
    /// </summary>
    /// <param name="pDataGridView"></param>
    /// <param name="pBindingSource"></param>
    public static void MoveRowUp(this DataGridView pDataGridView, BindingSource pBindingSource)
    {
        if (!string.IsNullOrWhiteSpace(pBindingSource.Sort))
        {
            pBindingSource.Sort = "";
        }

        var currentColumnIndex = pDataGridView.CurrentCell.ColumnIndex;
        var newIndex = Convert.ToInt32((pBindingSource.Position == 0) ? 0 : pBindingSource.Position - 1);

        var dt = (DataTable)pBindingSource.DataSource;

        DataRow rowToMove = ((DataRowView)pBindingSource.Current).Row;
        var newRow = dt.NewRow();

        newRow.ItemArray = rowToMove.ItemArray;
        dt.Rows.RemoveAt(pBindingSource.Position);
        dt.Rows.InsertAt(newRow, newIndex);

        dt.AcceptChanges();

        pBindingSource.Position = newIndex;
       
        pDataGridView.CurrentCell = pDataGridView[currentColumnIndex, newIndex];
    }

    /// <summary>
    /// Move selected row bound via a BindingSource up/down
    /// </summary>
    /// <param name="pDataGridView"></param>
    /// <param name="pBindingSource"></param>
    public static void MoveRowDown(this DataGridView pDataGridView, BindingSource pBindingSource)
    {
        if (!string.IsNullOrWhiteSpace(pBindingSource.Sort))
        {
            pBindingSource.Sort = "";
        }

        var currentColumnIndex = pDataGridView.CurrentCell.ColumnIndex;
        var upperLimit = pBindingSource.Count - 1;
        var newIndex = Convert.ToInt32((pBindingSource.Position + 1 >= upperLimit) ? upperLimit : pBindingSource.Position + 1);

        var dt = (DataTable)pBindingSource.DataSource;
        DataRow rowToMove = ((DataRowView)pBindingSource.Current).Row;
        var newRow = dt.NewRow();

        newRow.ItemArray = rowToMove.ItemArray;
        dt.Rows.RemoveAt(pBindingSource.Position);
        dt.Rows.InsertAt(newRow, newIndex);

        dt.AcceptChanges();

        pBindingSource.Position = newIndex;
        pDataGridView.CurrentCell = pDataGridView[currentColumnIndex, newIndex];
    }

    public static void ExpandColumns(this DataGridView source, bool sizable = true)
    {
        foreach (DataGridViewColumn col in source.Columns)
        {
            if (col.ValueType.Name != "ICollection`1")
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        if (!sizable) return;

        for (int index = 0; index <= source.Columns.Count - 1; index++)
        {
            int columnWidth = source.Columns[index].Width;

            source.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Set Width to calculated AutoSize value:
            source.Columns[index].Width = columnWidth;
        }
    }
    public static void FixHeaders(this DataGridView source)
    {
        string SplitCamelCase(string sender)
            => string.Join(" ", Regex.Matches(sender,
                @"([A-Z][a-z]+)").Select(m => m.Value));

        for (int index = 0; index < source.Columns.Count; index++)
        {
            source.Columns[index].HeaderText = SplitCamelCase(source.Columns[index].HeaderText);
        }
    }
    /// <summary>
    /// Disable all columns sorting
    /// </summary>
    /// <param name="source"></param>
    public static void DisableSorting(this DataGridView source)
    {
        source.Columns
            .Cast<DataGridViewColumn>()
            .ToList()
            .ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
    }
    public static void EnableSorting(this DataGridView source)
    {
        source.Columns
            .Cast<DataGridViewColumn>()
            .ToList()
            .ForEach(f => f.SortMode = DataGridViewColumnSortMode.Automatic);
    }
}