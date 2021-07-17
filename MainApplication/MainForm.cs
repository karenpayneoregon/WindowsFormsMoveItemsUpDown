using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBackEnd;


namespace MainApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();

            Shown += MainForm_Shown;

        }
        /// <summary>
        /// Populate ComboBox with known categories for showing
        /// how to obtain the current/last RowPosition for a category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {

            var ops = new Operations();
            cboCategories.DataSource = ops.LoadCategories();

        }

        private void cmdUnboundDataGridViewFullRowSelect_Click(object sender, EventArgs e)
        {

            var f = new DataGridViewNoRememberForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }
        private void cmdBoundListBoxRememberPosition_Click(object sender, EventArgs e)
        {

            var f = new LoadProductListBoxForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }
        /// <summary>
        /// First show form which permits changing the order of rows.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdBoundDataGridView_Click(object sender, EventArgs e)
        {

            var f = new DataGridViewRememberForm();
            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (chkBoundDataGridViewRemember.Checked && f.HasChanges)
                    {
                        //var resultsForm = new DataGridViewResultsForm(f.CategoryIdentifier);
                        //try
                        //{
                        //    resultsForm.ShowDialog();
                        //}
                        //finally
                        //{
                        //    resultsForm.Dispose();
                        //}
                    }
                }
            }
            finally
            {
                f.Dispose();
            }

        }

        private void cmdCheckedListBoxExample_Click(object sender, EventArgs e)
        {

            var f = new CheckedListBoxForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }

        private void cmdBuildCustomerSelectStatement_Click(object sender, EventArgs e)
        {

            var f = new BuildSelectStatementForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }

        private void cmdListViewUnboundExample_Click(object sender, EventArgs e)
        {

            var f = new ListViewForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }
        /// <summary>
        /// When adding a new product a RowPosition is needed for moving rows
        /// up/down will work. After adding a new row it will display as the
        /// last row in the user interface.
        /// 
        /// This brings up another topic, removal of row(s), this means there
        /// will be a missing value in the sequence but will be handled after
        /// the first save is done when moving a row up/down. The user of the application
        /// will not notice this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNextCategoryRowPosition_Click(object sender, EventArgs e)
        {
            // get the primary key for the selected item in the ComboBox
            var id = ((Category) cboCategories.SelectedItem).id;           
            var ops = new Operations();
            // get the last RowPostion
            var lastRowPositionForSelectedCategory = ops.LastRowPositionForCategory(id);

            /*
             * demonstrate how to watch for run time exceptions
             */
            if (ops.IsSuccessFul)
            {
                MessageBox.Show($"Last RowPosition for '{cboCategories.Text}' is " +
                                $"{lastRowPositionForSelectedCategory}, next is " +
                                $"{lastRowPositionForSelectedCategory + 1}");
            }
            else
            {
                MessageBox.Show("Failed to get RowPosition");
            }

        }

        private void cmdJsonRemember_Click(object sender, EventArgs e)
        {

            var f = new ListViewJsonExampleForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }
    }
}
