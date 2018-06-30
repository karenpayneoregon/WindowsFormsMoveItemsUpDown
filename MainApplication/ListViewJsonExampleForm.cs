using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CommonLangageExtensionsLibrary;
using JsonLibrary;

namespace MainApplication
{
    /// <summary>
    /// Load json from disk, permit reordering, save.
    /// Each time the app runs the json file is reset 
    /// but not each time the form is shown.
    /// </summary>
    public partial class ListViewJsonExampleForm : Form
    {
        private FileOperations _ops = new FileOperations();

        private readonly string _fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
            "applications.json");

        public ListViewJsonExampleForm()
        {
            InitializeComponent();
            Shown += ListViewJsonExampleForm_Shown;
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

            var applicationList = _ops.LoadApplicationData(_fileName);
            foreach (var app in applicationList)
            {
                ListViewItem item;
                item = new ListViewItem(app.Items());
                item.Tag = app.id;
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
        /// <summary>
        /// Iterate each ListView item and store in a List of
        /// Application, pass the list off to a save method to
        /// save back to the file we read in on form shown event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSavePositions_Click(object sender, EventArgs e)
        {
            var appList = new List<JsonLibrary.Application>();

            for (int index = 0; index < listView1.Items.Count; index++)
            {
                appList.Add(new JsonLibrary.Application()
                {
                    id = Convert.ToInt32(listView1.Items[index].Tag),
                    ApplicationName = listView1.Items[index].SubItems[0].Text,
                    ApplicationVersion = listView1.Items[index].SubItems[1].Text,
                    ApplicationKey = listView1.Items[index].SubItems[2].Text
                });
            }

            _ops.SaveApplicationData(appList, _fileName);

            Close();

        }

    }
}
