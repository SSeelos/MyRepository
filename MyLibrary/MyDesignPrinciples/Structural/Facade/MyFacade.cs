using MyLibrary.MyUtilities;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Facade
{
    public class MyFacade
    {
        public string ConvenientMethodAB()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            var subClassA = new MyComplexSubSystem.MySubsystemClassA();
            var subClassB = new MyComplexSubSystem.MySubsystemClassB();


            return subClassA.Method() + " " + subClassB.Method();
        }
        public string ConvenientMethodAC()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            var subClassA = new MyComplexSubSystem.MySubsystemClassA();
            var subClassC = new MyComplexSubSystem.MySubsystemClassC();


            return subClassA.Method() + " " + subClassC.Method();
        }
    }
}
