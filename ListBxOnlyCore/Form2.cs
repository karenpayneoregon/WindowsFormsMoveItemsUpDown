using System.Data;
using System.Globalization;
using CommonLangageExtensionsLibraryCore;

namespace ListBxOnlyCore;
public partial class Form2 : Form
{
    private readonly BindingSource bindingSource = 
        new BindingSource();
    public Form2()
    {
        InitializeComponent();

        DataTable dt = new DataTable();

        // position in listbox
        dt.Columns.Add(new DataColumn()
        {
            AutoIncrement = true, 
            AutoIncrementSeed = 1, 
            DataType = typeof(int), 
            ColumnName = "RowPosition"
        });

        dt.Columns.Add(new DataColumn()
        {
            ColumnName = "MonthName", 
            DataType = typeof(string)
        });

        foreach (var month in DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToArray())
        {
            dt.Rows.Add(null, month);
        }

        bindingSource.DataSource = dt;
        listBox1.DataSource = bindingSource;
        listBox1.DisplayMember = "MonthName";
    }

    private void upButton_Click(object sender, EventArgs e)
    {
        listBox1.MoveRowUp(bindingSource, "RowPosition");
    }

    private void downButton_Click(object sender, EventArgs e)
    {
        listBox1.MoveRowDown(bindingSource, "RowPosition");
    }

    private void CurrentButton_Click(object sender, EventArgs e)
    {
        var current = ((DataRowView)bindingSource.Current).Row;
        MessageBox.Show($"{current.Field<int>("RowPosition"),-4}" + 
                        $"{current.Field<string>("MonthName")}");
    }
}
