namespace DataBackEnd
{
    public class SelectedSong
    {
        public int  Index { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
