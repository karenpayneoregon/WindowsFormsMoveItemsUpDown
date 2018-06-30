using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;
using DataBackEnd;

namespace MainApplication
{
    public partial class ListViewForm : Form
    {
        /// <summary>
        /// This is the field in the database table that hold the 
        /// position a record will be displayed
        /// </summary>
        private readonly Operations _ops = new Operations();
        ListViewItemContainerList _items = new ListViewItemContainerList();
        private List<ListViewItemContainer> _itemsClone;
        public ListViewForm()
        {
            InitializeComponent();
            Shown += ListViewForm_Shown;
        }
        private void ListViewForm_Shown(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.GridLines = true;
            listView1.OwnerDraw = false;
            listView1.FullRowSelect = true;

            // see notes in ListViewItemContainer.cs
            foreach (var vItem in _items.Items())
            {
                var item = listView1.Columns.Add(vItem.Name, vItem.Width);
                item.Text = vItem.Title;
            }

            _itemsClone = _items.Items().ConvertAll(item => item.Clone());

            var customerList = _ops.LoadCustomers();
            foreach (var cust in customerList)
            {
                var item = new ListViewItem(cust.Items());
                listView1.Items.Add(item);
            }

            listView1.Items[0].Selected = true;
            listView1.Select();
        }


        private void upButton_Click(object sender, EventArgs e)
        {
            listView1.MoveListViewItems(MoveDirection.Up);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            listView1.MoveListViewItems(MoveDirection.Down);
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"{Name}, {Contact}, {Title}";
        }
    }

    public class AccessOperations
    {
        private OleDbConnectionStringBuilder Builder = new OleDbConnectionStringBuilder
        {
            Provider = "Microsoft.ACE.OLEDB.12.0",
            DataSource = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database1.accdb")
        };

        public void InsertRecords(List<Company> pCompanies)
        {
            string insertStatement = "INSERT INTO Customer (CompanyName, ContactName, ContactTitle) " +
                                     "Values (@CompanyName, @ContactName, @ContactTitle)";

            using (OleDbConnection cn = new OleDbConnection {ConnectionString = Builder.ConnectionString})
            {
                using (OleDbCommand cmd = new OleDbCommand {Connection = cn, CommandText = "SELECT Title FROM Titles"})
                {
                    cmd.CommandText = insertStatement;
                    cmd.Parameters.Add(new OleDbParameter() {DbType = DbType.String, ParameterName = "@CompanyName"});
                    cmd.Parameters.Add(new OleDbParameter() { DbType = DbType.String, ParameterName = "@ContactName" });
                    cmd.Parameters.Add(new OleDbParameter() { DbType = DbType.String, ParameterName = "@ContactTitle" });
                    try
                    {
                        cn.Open();
                        foreach (Company company in pCompanies)
                        {
                            cmd.Parameters[0].Value = company.Name;
                            cmd.Parameters[1].Value = company.Contact;
                            cmd.Parameters[2].Value = company.Title;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception e)
                    {
                        // decide how to handle
                    }
                }
            }
        }
    }
}
