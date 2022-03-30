using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Facade
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
