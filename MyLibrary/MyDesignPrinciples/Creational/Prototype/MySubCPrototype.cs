using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
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
        public override string Output() => $"{base.Output()} {fieldCA}";
    }
}
