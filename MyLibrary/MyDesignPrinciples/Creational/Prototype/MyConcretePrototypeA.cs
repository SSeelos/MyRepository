using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public class MyConcretePrototypeA : _MyPrototype
    {
        private string fieldA;
        public MyConcretePrototypeA(string field, string fieldA)
            : base(field)
        {
            this.fieldA = fieldA;
        }
        public MyConcretePrototypeA(MyConcretePrototypeA prototype)
            : base(prototype)
        {
            this.fieldA = prototype.fieldA;
        }

        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            //constructor copy:
            return new MyConcretePrototypeA(this);
        }
        public override string Output()
        {
            return base.Output() + " " + this.fieldA;
        }
    }
}
