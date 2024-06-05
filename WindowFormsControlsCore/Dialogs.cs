

using WindowFormsControlsCore.Properties;

namespace WindowFormsControlsCore;

/// <summary>
/// Custom dialogs
/// </summary>
public class Dialogs
{
    /// <summary>
    /// For asking a question with No as the default button
    /// </summary>
    /// <param name="owner">Control to center on</param>
    /// <param name="heading">Text to display</param>
    /// <returns>true or false</returns>
    public static bool Question(Control owner, string heading)
    {

        TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
        TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

        var buttons = new TaskDialogButtonCollection
        {
            noButton,
            yesButton
        };

        TaskDialogPage page = new()
        {
            Caption = "Question",
            SizeToContent = true,
            Heading = heading,
            Icon = new TaskDialogIcon(Resources.QuestionBlue),
            Buttons = buttons
        };

        var result = TaskDialog.ShowDialog(owner, page);

        return (DialogResult)result.Tag! == DialogResult.Yes;

    }
}
