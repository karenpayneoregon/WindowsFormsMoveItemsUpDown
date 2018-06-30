using System;
using System.Data;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;
using DataBackEnd;

namespace MainApplication
{
    public partial class DataGridViewRememberForm : Form
    {
        /// <summary>
        /// This is the field in the database table that hold the 
        /// position a record will be displayed
        /// </summary>
        private Operations _ops = new Operations("RowPosition");
        /// <summary>
        /// Data source for ListBox
        /// </summary>
        private BindingSource _bsData = new BindingSource();
        /// <summary>
        /// Once a change is made e.g. a row is moved up or down this
        /// is set to true and if true on form closing will update the
        /// database table.
        /// </summary>
        private bool _hasChanges = false;

        public bool HasChanges
        {
            get { return _hasChanges; }
        }
        private int _CategoryIdentifier;
        public int CategoryIdentifier
        {
            get { return _CategoryIdentifier; }
        }
        public DataGridViewRememberForm()
        {
            InitializeComponent();
            FormClosing += DataGridViewRememberForm_FormClosing;
        }
        /// <summary>
        /// Check if there have been changes for row move up or down,
        /// if there are changes save back to the database table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewRememberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((DataTable) _bsData.DataSource).ReorderPositionMarker();
            if (DialogResult == DialogResult.OK)
            {
                if (_hasChanges)
                {
                    _ops.UpdateProductTable((DataTable)_bsData.DataSource);
                }
            }
        }
        /// <summary>
        /// Load products by random category.
        /// Hide CategoryId field
        /// Change the position of the field RowPosition from last
        /// column to first column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewRememberForm_Load(object sender, EventArgs e)
        {
            var dt = _ops.LoadProductsByCategory(-1);
            _CategoryIdentifier = _ops.CategoryIdentifier;

            dt.Columns["CategoryId"].ColumnMapping = MappingType.Hidden;
            dt.Columns["RowPosition"].SetOrdinal(0);
            _bsData.DataSource = dt;
            dataGridView1.DataSource = _bsData;
            dataGridView1.ExpandColumns();
        }
        /// <summary>
        /// Move current row up by one, mark _hasChanges to true
        /// to indicate we have at least one change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upButton_Click(object sender, EventArgs e)
        {
            _bsData.MoveRowUp();
            
            _hasChanges = true;
        }
        /// <summary>
        /// Move current row down by one, mark _hasChanges to true
        /// to indicate we have at least one change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downButton_Click(object sender, EventArgs e)
        {
            _bsData.MoveRowDown();
            
            _hasChanges = true;
        }
    }
}
