using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public class MySubBPrototype : MyConcretePrototypeB
    {
        private string fieldBA;
        public MySubBPrototype(MyConcretePrototypeB prototype, string fieldBA)
            : base(prototype)
        {
            this.fieldBA = fieldBA;
        }
        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            var copy = (MySubBPrototype)MemberwiseClone();

            return copy;
        }
        public override string Output() => $"{base.Output()} {fieldBA}";
    }
}
