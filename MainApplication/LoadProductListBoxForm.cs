using System;
using System.Data;
using System.Windows.Forms;
using DataBackEnd;
using CommonLangageExtensionsLibrary;

namespace MainApplication
{
    public partial class LoadProductListBoxForm : Form
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

        /// <summary>
        /// Subscribe to FormClosing which is were we save or not
        /// save dependent on if save or cancel button or the
        /// system X button was pressed.
        /// </summary>
        public LoadProductListBoxForm()
        {
            InitializeComponent();
            FormClosing += LoadProductListBoxForm_FormClosing;
        }

        /// <summary>
        /// Load all categories into a ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadProductListBoxForm_Load(object sender, EventArgs e)
        {
            cboCategories.DataSource = _ops.LoadCategories();
        }

        /// <summary>
        /// Load all products for the selected category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoadProducts_Click(object sender, EventArgs e)
        {
            _bsData.DataSource = null;

            var catIdentifier = ((Category) cboCategories.SelectedItem).CategoryID;
            _bsData.DataSource = _ops.LoadProductsByCategory(catIdentifier);

            lstProducts.DisplayMember = "ProductName";
            lstProducts.DataSource = _bsData;

            ActiveControl = lstProducts;
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex >= 0)
            {
                lstProducts.MoveRowUp(_bsData, _ops.KeyPositionFieldName);
                _hasChanges = true;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex >= 0)
            {
                lstProducts.MoveRowDown(_bsData, _ops.KeyPositionFieldName);
                _hasChanges = true;
            }
        }
        /// <summary>
        /// Only save if the save button was pressed while don't save if 
        /// cancel button was pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadProductListBoxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (_hasChanges)
                {
                    _ops.UpdateProductTable((DataTable)_bsData.DataSource);
                }
            }
        }
        /// <summary>
        /// This is for demo purposes, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (_hasChanges)
            {
                if (_ops.UpdateProductTable((DataTable)_bsData.DataSource))
                {
                    _ops.UpdateProductTable((DataTable)_bsData.DataSource);
                    _hasChanges = false;
                }
                else
                {
                    MessageBox.Show(_ops.LastExceptionMessage);
                }
            }
        }
    }
}
