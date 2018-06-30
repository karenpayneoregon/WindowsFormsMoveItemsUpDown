using System;
using System.Windows.Forms;
using DataBackEnd;

namespace MainApplication
{
    /// <summary>
    /// No direct link to moving rows up/down
    /// </summary>
    public partial class WizardForm : Form
    {
        public WizardForm()
        {
            InitializeComponent();
            Shown += WizardForm_Shown;
        }
        private void WizardForm_Shown(object sender, EventArgs e)
        {
            var ops = new Operations();
            var songList = ops.LoadAlbumSongs();

            foreach (var song in songList)
            {
                listBox1.Items.Add(song);
            }

        }
        private void cmdMoveToPurchase_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                var song = listBox1.SelectedItem;
                listBox2.Items.Add(song);
                listBox1.Items.Remove(song);
            }
            
        }
        private void cmdMoveFromPurchase_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem != null)
            {
                var song = listBox2.SelectedItem;
                listBox1.Items.Add(song);
                listBox2.Items.Remove(song);
            }

        }
    }
}
