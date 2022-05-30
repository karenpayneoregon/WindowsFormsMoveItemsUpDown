using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;

using Operations = ListBoxOnly.Classes.Operations;

// Data Source=.\SQLEXPRESS;Initial Catalog=OrderingRows1;Integrated Security=True
namespace ListBoxOnly
{
    public partial class LoadProductListBoxForm : Form
    {
        /// <summary>
        /// This is the field in the database table that hold the 
        /// position a record will be displayed
        /// </summary>
        private readonly Operations _operations = new Operations("RowPosition");
        /// <summary>
        /// Data source for ListBox
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();
        /// <summary>
        /// Once a change is made e.g. a row is moved up or down this
        /// is set to true and if true on form closing will update the
        /// database table.
        /// </summary>
        private bool _hasChanges;

        /// <summary>
        /// Subscribe to FormClosing which is were we save or not
        /// save dependent on if save or cancel button or the
        /// system X button was pressed.
        /// </summary>
        public LoadProductListBoxForm()
        {
            InitializeComponent();

            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _operations.UpdateProductTable((DataTable)_bindingSource.DataSource);
        }

        /// <summary>
        /// Load all categories into a ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadProductListBoxForm_Load(object sender, EventArgs e)
        {
            var (table, exception) = _operations.LoadProductsByCategoryId(1);
            if (exception == null)
            {
                _bindingSource.DataSource = table;

                lstProducts.DisplayMember = "ProductName";
                lstProducts.DataSource = _bindingSource;

                ActiveControl = lstProducts;
            }
            else
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex < 0) return;
            lstProducts.MoveRowUp(_bindingSource, _operations.KeyPositionFieldName);
            _hasChanges = true;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex < 0) return;
            lstProducts.MoveRowDown(_bindingSource, _operations.KeyPositionFieldName);
            _hasChanges = true;
        }
    }
}
