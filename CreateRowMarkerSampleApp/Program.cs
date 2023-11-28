using CreateRowMarkerSampleApp.Classes;

namespace CreateRowMarkerSampleApp;
internal partial class Program
{
    static async Task Main(string[] args)
    {
        await Setup();
        Operations operations = new Operations();
        await operations.ConfigureOrderDetailsForRowPosition();
        
        ExitPrompt();
    }
}