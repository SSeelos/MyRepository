using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;

namespace MyInstallerLib
{
    [RunInstaller(true)]
    public partial class MyInstaller : Installer
    {
        public MyInstaller()
        {
            InitializeComponent();
        }
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            //var version = Context.Parameters["version"];
        }
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }
        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
        }
        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }
    }
}
