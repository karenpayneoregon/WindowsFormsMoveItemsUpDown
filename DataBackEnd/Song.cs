namespace DataBackEnd
{
    public class Song
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public int RowPosition { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
