using MyLibrary_DotNETstd_2_1.MyUtilities;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Prototype
{
    public class MyConcretePrototypeB : _MyPrototype
    {
        private string _fieldB;
        public MyConcretePrototypeB(string fieldA, string fieldB)
            : base(fieldA)
        {
            _fieldB = fieldB;
        }

        public override _MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            //shallow copy
            var myClone = (MyConcretePrototypeB)MemberwiseClone();

            return myClone;
        }
        public override string Output() => $"{base.Output()} {this._fieldB}";
    }
}
