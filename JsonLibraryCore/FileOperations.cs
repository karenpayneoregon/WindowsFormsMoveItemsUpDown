using Newtonsoft.Json;

namespace JsonLibraryCore;

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
    /// <param name="fileName">File to read json from</param>
    /// <returns></returns>
    public List<Application> LoadApplicationData(string fileName)
    {
        using StreamReader reader = new(fileName);
        string json = reader.ReadToEnd();
        return JsonConvert.DeserializeObject<List<Application>>(json);
    }
    /// <summary>
    /// Takes a list of application stored in a ListView and save the
    /// data to a json file.
    /// </summary>
    /// <param name="pApplications">List of Application</param>
    /// <param name="fileName">Path and file name to save the list oo</param>
    public void SaveApplicationData(List<Application> pApplications, string fileName)
    {
        using StreamWriter writer = File.CreateText(fileName);
        var serializer = new JsonSerializer
        {
            Formatting = Formatting.Indented
        };

        serializer.Serialize(writer, pApplications);
    }

}