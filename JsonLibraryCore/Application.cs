namespace JsonLibraryCore
{
    public class Application
    {
        public int id { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationVersion { get; set; }
        public string ApplicationKey { get; set; }
        /// <summary>
        /// Used to load listView items in ListViewJsonExampleForm
        /// </summary>
        /// <returns></returns>
        public string[] Items() => new[] { ApplicationName, ApplicationVersion, ApplicationKey };
    }
}
