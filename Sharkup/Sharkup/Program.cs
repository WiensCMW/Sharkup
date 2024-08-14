internal class Program
{
    private static string _sourcePath = @"C:\Users\cornie\OneDrive - Vidir Solutions Inc\Desktop";
    private static string _stagingPath = @"C:\Users\cornie\Downloads\Sharkup\Staging";
    private static string _destinationPath = @"C:\Users\cornie\Downloads\Sharkup\Backups";

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Sharkup!");

        DirectoryInfo sourceDir = new DirectoryInfo(_sourcePath);
        DirectoryInfo stagingDr = new DirectoryInfo(_sourcePath);
        DirectoryInfo destinationDir = new DirectoryInfo(_sourcePath);

        FileInfo[] sourceFiles = sourceDir.GetFiles("*", SearchOption.AllDirectories);
        DirectoryInfo[] sourceFolders = sourceDir.GetDirectories("*", SearchOption.AllDirectories);
        Dictionary<string, DirectoryInfo> _sourceFoldersDict = new Dictionary<string, DirectoryInfo>();

        for (int i = 0; i < sourceFolders.Length; i++)
        {
            _sourceFoldersDict.Add(Path.GetRelativePath(sourceDir.FullName, sourceFolders[i].FullName), sourceFolders[i]);
        }

        Console.ReadKey();
    }
}