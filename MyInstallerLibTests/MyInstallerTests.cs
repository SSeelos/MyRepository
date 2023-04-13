using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Configuration.Install;
using System.IO;
using System.Reflection;

namespace MyInstallerLib.Tests
{
    [TestClass()]
    public class MyInstallerTests
    {
        [TestMethod()]
        public void MyInstallerTest()
        {
            var myInstaller = new Installer();

            string assemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string logFile = Path.Combine(assemblyDir, "install.log");
            myInstaller.Context = new InstallContext(logFile, null);

            var myParam = myInstaller.Context.Parameters["myParam"];

            myInstaller.Context.Parameters.Add("myKey", "myValue");

            // Our test isn't injecting any save state so we give a default instance for the stateSaver
            myInstaller.Install(new Hashtable());
            Assert.Fail();
        }

        [TestMethod()]
        public void InstallTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UninstallTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CommitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RollbackTest()
        {
            Assert.Fail();
        }
    }
}