using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public class MyConcretePrototypeC : _MyPrototype
    {
        private MyConcretePrototypeA _nestedPrototype;
        public MyConcretePrototypeC(MyConcretePrototypeA myConcretePrototypeA, string field)
            : base(field)
        {
            _nestedPrototype = myConcretePrototypeA;
        }

        //protected ctor copy
        protected MyConcretePrototypeC(MyConcretePrototypeC prototype)
            : base(prototype)
        {
            MyConcretePrototypeA myNestedPrototypeA = null;
            try
            {
                myNestedPrototypeA = (MyConcretePrototypeA)prototype._nestedPrototype.Clone();
            }
            catch
            {

            }
            _nestedPrototype = myNestedPrototypeA;
        }

        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            //protected ctor copy
            return new MyConcretePrototypeC(this);
        }
        public override string Output() => $"{base.Output()} {this._nestedPrototype.GetType().Name}";
    }
}
