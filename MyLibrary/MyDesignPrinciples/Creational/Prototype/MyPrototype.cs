using MyLibrary.MyUtilities;
using System.Reflection;

namespace MyLibrary.MyDesignPrinciples.Prototype
{
    public interface IPrototype
    {
        MyPrototype Clone();
    }
    public abstract class MyPrototype : IPrototype
    {
        protected string field;

        public MyPrototype(string field)
        {
            this.field = field;
        }
        public MyPrototype(MyPrototype prototype)
        {
            this.field = prototype.field;
        }

        public abstract MyPrototype Clone();

        public virtual string Output() { return this.GetType().Name + ": " + this.field; }


    }

    public class MyConcretePrototypeA : MyPrototype
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

        public override MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return new MyConcretePrototypeA(this);
        }
        public override string Output()
        {
            return base.Output() + " " + this.fieldA;
        }
    }
    public class MyConcretePrototypeB : MyPrototype
    {
        private string fieldB;
        public MyConcretePrototypeB(string field, string fieldB)
            : base(field)
        {
            this.fieldB = fieldB;
        }
        public MyConcretePrototypeB(MyConcretePrototypeB prototype)
            : base(prototype)
        {
            this.fieldB = prototype.fieldB;
        }

        public override MyPrototype Clone()
        {
            MyConsoleLogger.Instance.ClassMethodLog(this.GetType(), MethodBase.GetCurrentMethod());

            return new MyConcretePrototypeB(this);
        }
        public override string Output()
        {
            return base.Output() + " " + this.fieldB;
        }
    }
}
