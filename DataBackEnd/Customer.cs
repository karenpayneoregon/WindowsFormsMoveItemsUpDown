namespace DataBackEnd
{
    /// <summary>
    /// Partial column list for ListView demo
    /// </summary>
    public class Customer
    {
        public int CustomerIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string RowPositionFieldName { get; set; }
        /// <summary>
        /// Used to load the ListView
        /// </summary>
        /// <returns></returns>
        public string[] Items()
        {
            return new[] {CompanyName, ContactName, ContactTitle};
        }
    }
}
