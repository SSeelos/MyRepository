using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public class MySubAPrototype : MyConcretePrototypeA
    {
        private string _fieldAA;
        public MySubAPrototype(MyConcretePrototypeA prototypeA, string fieldAA)
            : base(prototypeA)
        {
            _fieldAA = fieldAA;
        }
        public MySubAPrototype(MySubAPrototype prototype)
            : base(prototype)
        {
            this._fieldAA = prototype._fieldAA;
        }
        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return new MySubAPrototype(this);
        }
    }
}
