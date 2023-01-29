using System.Data;
using CommonLangageExtensionsLibraryCore;
using DataGridViewCore.Classes;
// ReSharper disable PossibleNullReferenceException

namespace DataGridViewCore;

public partial class Form1 : Form
{
    /// <summary>
    /// This is the field in the database table that hold the 
    /// position a record will be displayed
    /// </summary>
    private readonly Operations _operations = new ();

    /// <summary>
    /// Data source for ListBox
    /// </summary>
    private readonly BindingSource _bindingSource = new();
    /// <summary>
    /// Once a change is made e.g. a row is moved up or down this
    /// is set to true and if true on form closing will update the
    /// database table.
    /// </summary>
    private bool _hasChanges;

    public bool HasChanges => _hasChanges;
    private int _categoryIdentifier;
    public int CategoryIdentifier => _categoryIdentifier;

    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
        FormClosing += OnFormClosing;
    }

    private void Form1_Shown(object? sender, EventArgs e)
    {
        DataTable table = _operations.LoadProductsByCategory(1);
        _categoryIdentifier = _operations.CategoryIdentifier;

        table.Columns["CategoryId"].ColumnMapping = MappingType.Hidden;
        table.Columns["RowPosition"].SetOrdinal(0);

        _bindingSource.DataSource = table;
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();
        dataGridView1.Columns[0].Width += 30;

    }

    private void OnFormClosing(object? sender, FormClosingEventArgs e)
    {
        if (_hasChanges)
        {
            _operations.UpdateProductTable((DataTable)_bindingSource.DataSource);
        }
    }

    private void upButton1_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveRowUp();

        _hasChanges = true;
    }

    private void downButton1_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveRowDown();

        _hasChanges = true;
    }
}
