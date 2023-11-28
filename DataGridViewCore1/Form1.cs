using System.Data;
using CommonLangageExtensionsLibraryCore;
using DataGridViewCore1.Classes;

namespace DataGridViewCore1;

public partial class Form1 : Form
{
    private readonly BindingSource _bindingSource = new();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        _bindingSource.DataSource = DataOperations.Load();
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();
        dataGridView1.DisableSorting();
    }

    private void upButton_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveRowUp();
    }

    private void downButton_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveRowDown();
    }

    private void currentButton_Click(object sender, EventArgs e)
    {
        var row = ((DataRowView)_bindingSource.Current).Row;
        var name = $"{row.Field<string>("FirstName")} " +
                   $"row.Field<string>(\"FirstName\")}}";
    }

    private void dumpButton_Click(object sender, EventArgs e)
    {
        DataTable dt = (DataTable)_bindingSource.DataSource;
        File.WriteAllText("dump.json", DataOperations.DataTableToJson(dt));
    }
}
