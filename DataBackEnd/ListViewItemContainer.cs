using System.Collections.Generic;
/*
 * Code here was to answer a forum question and really for this
 * article has no baring on moving rows in a ListView up/down yet
 * left as this is the base for reordering, hiding columns and changing
 * the title of columns.
 */
namespace DataBackEnd
{
    public class ListViewItemContainer : ICloneable<ListViewItemContainer>
    {
        public int DisplayIndex { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int Width { get; set; }

        public ListViewItemContainer Clone()
        {
            return new ListViewItemContainer()
            {
                DisplayIndex = DisplayIndex,
                Name = Name,
                Title = Title,
                Width = Width
            };
        }
    }
    public class ListViewItemContainerList
    {
        public List<ListViewItemContainer> Items()
        {
            return new List<ListViewItemContainer>()
            {
                new ListViewItemContainer() {DisplayIndex = 0, Title = "Company", Name = "CompanyName", Width = 200 },
                new ListViewItemContainer() {DisplayIndex = 1, Title = "Contact", Name = "ContactName", Width = 130 },
                new ListViewItemContainer() {DisplayIndex = 2, Title = "Title", Name = "ContactTitle", Width = 160 }
            };
        }
    }
}
