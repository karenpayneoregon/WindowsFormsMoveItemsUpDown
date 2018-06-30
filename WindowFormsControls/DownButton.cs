using System.Drawing;
using System.Windows.Forms;

namespace WindowFormsControls
{
    public class DownButton : Button
    {
        public DownButton() : base()
        {
            Image = Properties.Resources.DnArrow;
            Size = new Size(44, 40);
            Paint += DownButton_Paint1;
        }

        private void DownButton_Paint1(object sender, PaintEventArgs e)
        {
            Text = "";
        }
    }
}
