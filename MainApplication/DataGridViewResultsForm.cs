using System;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;
using DataBackEnd;

namespace MainApplication
{
    public partial class DataGridViewResultsForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private Operations _ops = new Operations("RowPosition");
        public DataGridViewResultsForm()
        {
            InitializeComponent();
        }

        private int _categoryIdentifier;
        public DataGridViewResultsForm(int pCategoryIdentifier)
        {
            InitializeComponent();

            _categoryIdentifier = pCategoryIdentifier;

            Shown += DataGridViewResultsForm_Shown;
        }
        private void DataGridViewResultsForm_Shown(object sender, EventArgs e)
        {           
            _bindingSource.DataSource = _ops.LoadProductsByCategory(_categoryIdentifier);           
            _bindingSource.Sort = _ops.KeyPositionFieldName;
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.ExpandColumns();
        }
    }
}
