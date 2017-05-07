using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace RunBatFileWithSameNameAsThisExeFileInSameFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(Path.ChangeExtension(Assembly.GetEntryAssembly().Location, "bat"));
        }
    }
}