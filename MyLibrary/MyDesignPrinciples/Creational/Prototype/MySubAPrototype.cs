using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public class MySubAPrototype : MyConcretePrototypeA
    {
        private string fieldAA;
        public MySubAPrototype(MySubAPrototype prototype) : base(prototype)
        {
            this.fieldAA = prototype.fieldAA;
        }
        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return new MySubAPrototype(this);
        }
    }
    public class MySubCPrototype : MyConcretePrototypeC
    {
        private string fieldCA;
        public MySubCPrototype(MyConcretePrototypeA prototype, string field, string fieldCA)
            : base(prototype, field)
        {
            this.fieldCA = fieldCA;
        }
        protected MySubCPrototype(MySubCPrototype mySubCPrototype)
            : base(mySubCPrototype)
        {
            this.fieldCA = mySubCPrototype.fieldCA;
        }
        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return new MySubCPrototype(this);
        }
    }
}
