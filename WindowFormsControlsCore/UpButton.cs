namespace WindowFormsControlsCore;

public class UpButton : Button
{
    public UpButton()
    {
        Image = Properties.Resources.UpBlackSmall;
        Size = new Size(44, 40);
        Paint += UpButton_Paint!;
    }

    private void UpButton_Paint(object sender, PaintEventArgs e)
    {
        Text = "";
    }
}