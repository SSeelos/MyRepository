using Microsoft.Deployment.WindowsInstaller;
using System.Windows.Forms;

namespace MyWiX
{
    public class CustomAcitons
    {
        [CustomAction]
        public static ActionResult MyCustomAction(Session session)
        {
            MessageBox.Show($"{nameof(MyCustomAction)}()");
            session.Log($"session: {nameof(MyCustomAction)}()");

            return ActionResult.Success;
        }
    }
}
