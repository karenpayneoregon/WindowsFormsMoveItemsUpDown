using DapperLibrary1.Extensions;
using DapperLibrary1.Models;
using DapperLibrary1.Repositories;
using DataGridViewCore2.Extensions;
using DataGridViewCore2.MockingClasses;
using WindowFormsControlsCore;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace DataGridViewCore2;

public partial class Form1 : Form
{
    PersonRepository repo = new();
    private readonly BindingSource _bindingSource = [];

    public Form1()
    {
        InitializeComponent();
        dataGridView1.AutoGenerateColumns = false;
        Shown += Form1_Shown;
        Closing += Form1_Closing;
    }

    private void Form1_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
    {
        if (_bindingSource.DataSource is List<Person> people)
        {
            people.ReorderPositionMarker();
            repo.UpdatePeople(people);
        }
    }

    private async void Form1_Shown(object? sender, EventArgs e)
    {

        _bindingSource.DataSource = await repo.GetAllAsync();
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.FixHeaders();
        dataGridView1.ExpandColumns();
        dataGridView1.DisableSorting();

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

    private async void ResetPersonDataButton_Click(object sender, EventArgs e)
    {
        if (Dialogs.Question(this, "Reset Person table?"))
        {
            await ResetPersonData();
        }
    }

    private async Task ResetPersonData()
    {
        repo.Reset();
        await repo.AddRangeSlim(BogusOperations.People(5));
    }
}
