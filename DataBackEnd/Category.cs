namespace DataBackEnd
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int id { get; set; }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}
