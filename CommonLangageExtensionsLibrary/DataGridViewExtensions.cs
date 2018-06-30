using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLangageExtensionsLibrary
{
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
        /// <summary>
        /// Expand all columns to fill the largest value in each column
        /// </summary>
        /// <param name="sender"></param>
        public static void ExpandColumns(this DataGridView sender)
        {
            foreach (DataGridViewColumn col in sender.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
