using ListBxOnlyCore.Classes;
using System.ComponentModel;
using System.Data;
using CommonLangageExtensionsLibraryCore;

namespace ListBxOnlyCore;

public partial class Form1 : Form
{
    /// <summary>
    /// This is the field in the database table that hold the 
    /// position a record will be displayed
    /// </summary>
    private readonly Operations _operations = new Operations("RowPosition");
    /// <summary>
    /// Data source for ListBox
    /// </summary>
    private readonly BindingSource _bindingSource = new ();
    /// <summary>
    /// Once a change is made e.g. a row is moved up or down this
    /// is set to true and if true on form closing will update the
    /// database table.
    /// </summary>
    private bool _hasChanges;
    public Form1()
    {
        InitializeComponent();
        Closing += OnClosing;
        Shown += Form1_Shown;
    }

    private void Form1_Shown(object sender, EventArgs e)
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

    private void OnClosing(object sender, CancelEventArgs e)
    {
        _operations.UpdateProductTable((DataTable)_bindingSource.DataSource);
    }

    private void upButton1_Click(object sender, EventArgs e)
    {
        MoveUp();
    }

    private void MoveUp()
    {
        if (lstProducts.SelectedIndex < 0) return;
        lstProducts.MoveRowUp(_bindingSource, _operations.KeyPositionFieldName);
        _hasChanges = true;
    }

    private void downButton1_Click(object sender, EventArgs e)
    {
        MoveDown();
    }

    private void MoveDown()
    {
        if (lstProducts.SelectedIndex < 0) return;
        lstProducts.MoveRowDown(_bindingSource, _operations.KeyPositionFieldName);
        _hasChanges = true;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Control | Keys.Up))
        {
            MoveUp();
            return true;
        }
        else if (keyData == (Keys.Control | Keys.Down))
        {
            MoveDown();
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }
}
