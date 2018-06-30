using System;
using System.Linq;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;
using DataBackEnd;

namespace MainApplication
{
    /// <summary>
    /// Starter for showing how to permit a user to reposition fields
    /// in a SELECT statement and select a order by
    /// 
    /// For an advance example see the following MSDN code sample written
    /// by the same author as this code sample.
    /// 
    /// This example is primed for this code.
    /// 
    /// Database/table/field objects are retrieved via SMO SQL-Server
    /// Management Objects.
    /// https://code.msdn.microsoft.com/Working-with-SQL-Server-b204d549?redir=0
    /// 
    /// If having issues finding the proper references for the above code sample
    /// see the following (part 1)
    /// https://code.msdn.microsoft.com/Working-with-SQL-Server-2443a157?redir=0
    /// </summary>
    public partial class BuildSelectStatementForm : Form
    {
        public BuildSelectStatementForm()
        {
            InitializeComponent();
            Shown += BuildSelectStatementForm_Shown;
            checkedListBox1.ItemCheck += CheckedListBox1_ItemCheck;
        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = checkedListBox1.Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                if (listBox1.FindString(item) == -1)
                {
                    listBox1.Items.Add(item);
                }                
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.FindString(item));
            }
        }

        private void BuildSelectStatementForm_Shown(object sender, EventArgs e)
        {
            var ops = new Operations();
            var columnNames = ops.LoadCustomersColumns();
            foreach (string colName in columnNames)
            {
                checkedListBox1.Items.Add(colName);
            }
        }

        private void upButton1_Click(object sender, EventArgs e)
        {
            checkedListBox1.MoveItem();
        }

        private void downButton1_Click(object sender, EventArgs e)
        {
            checkedListBox1.MoveItem(false);
        }
        /// <summary>
        /// Generated a SELECT statement where column names are 
        /// ordered as in the CheckedListBox meanind first to last.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            var selectedColumns = string.Join(",", checkedListBox1.CheckedItems.Cast<string>().ToArray());
            if (!string.IsNullOrWhiteSpace(selectedColumns))
            {
                txtResults.Text = listBox1.SelectedIndex > -1
                    ? $"SELECT {selectedColumns} FROM dbo.Customers ORDER BY {listBox1.Text}"
                    : $"SELECT {selectedColumns} FROM Customers";
            }
            else
            {
                MessageBox.Show("Please select one or more columns");
            }
        }

        private void cmdNoOrderBy_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }
    }
}
