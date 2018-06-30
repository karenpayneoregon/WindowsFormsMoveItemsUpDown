using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace JsonLibrary
{
    /// <summary>
    /// Responsible, using JsonNet to read and write json
    /// from a json file to and from a concrete class
    /// </summary>
    public class FileOperations
    {
        /// <summary>
        /// Read json file into a list which will be passed to
        /// a form to load into a ListView
        /// </summary>
        /// <param name="pFileName">File to read json from</param>
        /// <returns></returns>
        public List<Application> LoadApplicationData(string pFileName)
        {

            using (StreamReader r = new StreamReader(pFileName))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Application>>(json);
            }

        }
        /// <summary>
        /// Takes a list of application stored in a ListView and save the
        /// data to a json file.
        /// </summary>
        /// <param name="pApplications">List of Application</param>
        /// <param name="pFileName">Path and file name to save the list oo</param>
        public void SaveApplicationData(List<Application> pApplications, string pFileName)
        {

            using (StreamWriter file = File.CreateText(pFileName))
            {
                var serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };

                serializer.Serialize(file, pApplications);
            }

        }

    }
}
