using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataBackEnd;

namespace MainApplication
{
    /// <summary>
    /// This form and code are only for writing the article for perspective.
    /// </summary>
    public partial class CustomerForm : Form
    {
        private BindingSource _bsCustomers = new BindingSource();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

            var ops = new Operations();
            var dt = ops.LoadCustomersByDataTable();
            var columnNames = ops.LoadCustomersColumns();

            if (!ops.HasException)
            {
                _bsCustomers.DataSource = dt;
                dataGridView1.DataSource = _bsCustomers;


                columnNames.Insert(0, "None");
                cboSortColumns.DataSource = columnNames;

                cboDirection.SelectedIndex = 0;
      
            }
            else
            {
                cmdSort.Enabled = false;
            }

        }

        private void cmdSort_Click(object sender, EventArgs e)
        {
            if (cboSortColumns.Text == "None")
            {
                _bsCustomers.Sort = "";
            }
            else
            {
                _bsCustomers.Sort = 
                    $"{cboSortColumns.Text} {cboDirection.Text}";
            }
        }
    }
}
