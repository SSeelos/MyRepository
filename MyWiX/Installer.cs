using Microsoft.Deployment.WindowsInstaller;
using System.Windows.Forms;
using WixSharp;

namespace MyWiX
{
    public static class Installer
    {
        static string productName = "MyProduct";
        public static void Main(string[] args)
        {
            var dir = new Dir($@"ProgramFiles\MyCompany\{productName}",
                new DirFiles(@"Release\Bin\*.*"));

            var project = new Project(productName, dir);

            project.BuildMsi();
        }
    }

    public class CustomAcitons
    {
        [CustomAction]
        public static ActionResult MyAction(Session session)
        {
            MessageBox.Show($"{nameof(MyAction)}()");
            session.Log($"session: {nameof(MyAction)}()");

            return ActionResult.Success;
        }
    }
}
