using System.Data;
#pragma warning disable CS8602

namespace CommonLangageExtensionsLibraryCore;

public static class ListBoxExtensions
{
    /// <summary>
    /// Move current item up one
    /// </summary>
    /// <param name="sender"></param>
    public static void MoveRowUp(this ListBox sender) 
    {
        var selectedIndex = sender.SelectedIndex;

        if (selectedIndex > 0)
        {
            sender.Items.Insert(selectedIndex - 1, sender.Items[selectedIndex]);
            sender.Items.RemoveAt(selectedIndex + 1);
            sender.SelectedIndex = selectedIndex - 1;
        }

    }
    /// <summary>
    /// Move current item down one
    /// </summary>
    /// <param name="sender"></param>
    public static void MoveRowDown(this ListBox sender)
    {
        var selectedIndex = sender.SelectedIndex;

        if (selectedIndex < sender.Items.Count - 1 & selectedIndex != -1)
        {
            sender.Items.Insert(selectedIndex + 2, sender.Items[selectedIndex]);
            sender.Items.RemoveAt(selectedIndex);
            sender.SelectedIndex = selectedIndex + 1;
        }

    }
    /// <summary>
    /// Move selected item up
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="pBindingSource">DataSource of ListBox</param>
    /// <param name="pRowPositionFieldName">Field name for remembering position in database table</param>
    public static void MoveRowUp(this ListBox sender, BindingSource pBindingSource, string pRowPositionFieldName)
    {
        if (!string.IsNullOrWhiteSpace(pBindingSource.Sort))
        {
            pBindingSource.Sort = "";
        }

        string displayText = sender.Text;
        var selectedIndex = pBindingSource.Position;
        var newIndex = Convert.ToInt32((pBindingSource.Position == 0) ? 0 : pBindingSource.Position - 1);

        var dt = (DataTable)pBindingSource.DataSource;
        var moveColIndex = dt.Columns[pRowPositionFieldName].Ordinal;

        DataRow rowToMove = ((DataRowView)pBindingSource.Current).Row;
        DataRow newRow = dt.NewRow();
        newRow.ItemArray = rowToMove.ItemArray;
        dt.Rows.RemoveAt(selectedIndex);
        dt.Rows.InsertAt(newRow, newIndex);

        dt.AcceptChanges();

        pBindingSource.Position = pBindingSource.Find(sender.DisplayMember, displayText);

        for (var index = 0; index < dt.Rows.Count; index++)
        {
            dt.Rows[index][moveColIndex] = index;
        }

    }
    /// <summary>
    /// Move selected item down
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="pBindingSource">DataSource of ListBox</param>
    /// <param name="pRowPositionFieldName">Field name for remembering position in database table</param>
    public static void MoveRowDown(this ListBox sender, BindingSource pBindingSource, string pRowPositionFieldName)
    {
        if (!string.IsNullOrWhiteSpace(pBindingSource.Sort))
        {
            pBindingSource.Sort = "";
        }

        string displayText = sender.Text;
        var selectIndex = pBindingSource.Position;

        var upperLimit = pBindingSource.Count - 1;
        var newIndex = Convert.ToInt32((pBindingSource.Position + 1 >= upperLimit) ? upperLimit : pBindingSource.Position + 1);

        var dt = (DataTable)pBindingSource.DataSource;
        var moveColIndex = dt.Columns[pRowPositionFieldName].Ordinal;

        DataRow rowToMove = ((DataRowView)pBindingSource.Current).Row;
        DataRow newRow = dt.NewRow();
        newRow.ItemArray = rowToMove.ItemArray;
        dt.Rows.RemoveAt(selectIndex);
        dt.Rows.InsertAt(newRow, newIndex);

        dt.AcceptChanges();

        pBindingSource.Position = pBindingSource.Find(sender.DisplayMember, displayText);

        for (var index = 0; index < dt.Rows.Count; index++)
        {
            dt.Rows[index][moveColIndex] = index;

        }

    }

}