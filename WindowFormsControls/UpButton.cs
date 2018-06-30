using System.Drawing;
using System.Windows.Forms;

namespace WindowFormsControls
{
    public class UpButton : Button
    {
        public UpButton()
        {
            Image = Properties.Resources.UpArrow;
            Size = new Size(44, 40);
            Paint += UpButton_Paint;
        }

        private void UpButton_Paint(object sender, PaintEventArgs e)
        {
            Text = "";
        }
    }
}
