using System;
using System.Linq;
using System.Windows.Forms;
using DataBackEnd;
using CommonLangageExtensionsLibrary;

namespace MainApplication
{
    public partial class CheckedListBoxForm : Form
    {
        public CheckedListBoxForm()
        {
            InitializeComponent();
            Shown += CheckedListBoxForm_Shown;
        }

        private void CheckedListBoxForm_Shown(object sender, EventArgs e)
        {
            var ops = new Operations();
            var songList = ops.LoadAlbumSongs();

            foreach (Song song in songList)
            {
                checkedListBox1.Items.Add(song);
            }
        }

        private void upButton1_Click(object sender, EventArgs e)
        {
            checkedListBox1.MoveItem();
        }

        private void downButton1_Click(object sender, EventArgs e)
        {
            checkedListBox1.MoveItem(false);            
        }
        /// <summary>
        /// If there are selections then move them to the ListBox
        /// in the order done in the CheckedListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                return;
            }

            var selected = checkedListBox1.CheckedItems.Cast<Song>().ToList();
            selected.ForEach(song => listBox1.Items.Add(song));

            foreach (Song song in selected)
            {
                checkedListBox1.Items.Remove(song);
            }

        }
        /// <summary>
        /// Move current ListBox item (Song) up one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upButton_Click(object sender, EventArgs e)
        {
            listBox1.MoveRowUp();
        }
        /// <summary>
        /// Move current ListBox item (Song) down one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downButton_Click(object sender, EventArgs e)
        {
            listBox1.MoveRowDown();
        }

        private void cmdPurchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase code goes here");
        }
    }
}
