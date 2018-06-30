using System.Windows.Forms;

namespace CommonLangageExtensionsLibrary
{
    public static class CheckedListBoxExtensions
    {
        /// <summary>
        /// Move a selected item up or down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pDirectionUp">
        /// true to move up, false to move down (default is move up)
        /// </param>
        public static void MoveItem(this CheckedListBox sender, bool pDirectionUp = true) 
        {
            if (sender.SelectedItem == null)
            {
                return;
            }

            sender.BeginUpdate();

            try
            {

                var selectedIndex = sender.SelectedIndex;
                object selectedItem = sender.SelectedItem;
                var checkedState = sender.GetItemChecked(selectedIndex);

                sender.Items.RemoveAt(selectedIndex);

                var newIndex = selectedIndex;
                if (pDirectionUp)
                {
                    newIndex = newIndex - 1;
                }
                else
                {
                    newIndex = newIndex + 1;
                }

                if (newIndex > sender.Items.Count - 1 | newIndex < 0)
                {
                    newIndex = sender.Items.Count;
                }


                sender.Items.Insert(newIndex, selectedItem);
                sender.SetItemChecked(newIndex, checkedState);

                sender.SelectedIndex = newIndex;
            }
            finally
            {
                sender.EndUpdate();
            }
        }
    }
}
