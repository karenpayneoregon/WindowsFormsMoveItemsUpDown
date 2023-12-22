using DapperLibrary1.Extensions;
using DapperLibrary1.Models;
using DapperLibrary1.Repositories;
using DataGridViewCore2.Extensions;
using DataGridViewCore2.MockingClasses;

namespace DataGridViewCore2;

public partial class Form1 : Form
{
    PersonRepository repo = new();
    private readonly BindingSource _bindingSource = new();

    public Form1()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private async Task InitialSetup()
    {
        repo.Reset();
        await repo.AddRangeSlim(BogusOperations.People(5));
    }
    private async void Form1_Shown(object? sender, EventArgs e)
    {

        await InitialSetup();
        _bindingSource.DataSource = await repo.GetAllAsync();
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();
        dataGridView1.DisableSorting();
        dataGridView1.Columns[0].Visible = false;
    }

    private void upButton1_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveRowUp<Person>();
    }
    private void downButton1_Click(object sender, EventArgs e)
    {
        _bindingSource.MoveRowDown<Person>();
    }
    private void DumpToJsonButton_Click(object sender, EventArgs e)
    {
        _bindingSource.ToJsonFile();
    }
}
