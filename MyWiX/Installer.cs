using WixSharp;

namespace MyWiX
{
    public static class Installer
    {
        static string productName = "MyProduct";
        public static void Main(string[] args)
        {
            var dir = new Dir($@"%ProgramFiles%\MyCompany\{productName}",
                new DirFiles(@"Release\Bin\*.*"));

            var project = new Project(productName,
                new ManagedAction(nameof(CustomAcitons.MyCustomAction)))
            {
                Dirs = new Dir[] { dir },
            };

            project.BuildMsi();
        }
    }
}
