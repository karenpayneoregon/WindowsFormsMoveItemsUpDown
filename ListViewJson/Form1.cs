using CommonLangageExtensionsLibraryCore;
using JsonLibraryCore;

namespace ListViewJson;

public partial class Form1 : Form
{
    private FileOperations _operations = new();

    private readonly string _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
        "applications.json");
    public Form1()
    {
        InitializeComponent();
        Shown += ListViewJsonExampleForm_Shown!;
    }


    /// <summary>
    /// Load json file, a key factor is the key/identifier is
    /// stored in the tag property of each list item so when
    /// saving we have it to make each record complete.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListViewJsonExampleForm_Shown(object sender, EventArgs e)
    {
        listView1.View = View.Details;

        listView1.GridLines = true;
        listView1.OwnerDraw = false;
        listView1.FullRowSelect = true;

        //Add column header
        listView1.Columns.Add("NameColumn", 200);
        listView1.Columns.Add("VersionColumn", 130);
        listView1.Columns.Add("KeyColumn", 160);

        listView1.Columns[0].Text = "Name";
        listView1.Columns[1].Text = "Version";
        listView1.Columns[2].Text = "Key";

        var applicationList = _operations.LoadApplicationData(_fileName);
        foreach (var app in applicationList)
        {
            var item = new ListViewItem(app.Items())
            {
                Tag = app.id
            };
            listView1.Items.Add(item);
        }

        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        listView1.Items[0].Selected = true;
        listView1.Select();
    }

    private void upButton1_Click(object sender, EventArgs e)
    {
        listView1.MoveListViewItems(MoveDirection.Up);
    }

    private void downButton1_Click(object sender, EventArgs e)
    {
        listView1.MoveListViewItems(MoveDirection.Down);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        var appList = new List<JsonLibraryCore.Application>();

        for (int index = 0; index < listView1.Items.Count; index++)
        {
            appList.Add(new JsonLibraryCore.Application()
            {
                id = Convert.ToInt32(listView1.Items[index].Tag),
                ApplicationName = listView1.Items[index].SubItems[0].Text,
                ApplicationVersion = listView1.Items[index].SubItems[1].Text,
                ApplicationKey = listView1.Items[index].SubItems[2].Text
            });
        }

        _operations.SaveApplicationData(appList, _fileName);

        Close();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Control | Keys.Up))
        {
            listView1.MoveListViewItems(MoveDirection.Up);
            return true;
        }else if (keyData == (Keys.Control | Keys.Down))
        {
            listView1.MoveListViewItems(MoveDirection.Down);
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }
}
