using MySystemExtensions;
using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyClass : _MyAbstractClass, IMyInterfaceA, IMyIntefaceB
    {
        #region Members
        //Methods, properties, events, constructors, and fields
        //are collectively referred to as members.

        //The means by which framework functionality is exposed to the end users of a framework.

        #region Fields

        //a type should be designed so that changes to fields of that type (name or type changes)
        //can be made without breaking code other than for members of the type.
        //This implies that all fields must be private.

        //(private :accessibility within the same class)
        private string myField;

        //excluded from this strict restriction are constant and static read-only fields,
        //because such fields, are never required to change.
        public const string myConstant = "const value";
        //all instances of the class share static fields
        public static readonly string myStaticReadonlyField;

        #endregion

        #region Properties

        //attributes    (public: accessible by any code within current or external assembly)
        public double myAttribute = 1;

        public string myGet { get; }
        public string myGetPrivateSet { get; private set; }
        public readonly string myReadonly;

        //(auto-implemented) property: field with get/set block
        public int MyAutoProperty { get; set; }

        //all instances of the class share static properties
        public static string myStaticProperty { get; set; }


        #region Advanced Property

        public double Min;
        public double Max;

        //backing field
        private double _myValue;
        public double MyClampedValue
        {
            get => _myValue;
            set
            {
                _myValue = Math.Clamp(value, Min, Max);
                MyValueChanged?.Invoke(_myValue);
            }
        }
        public event Action<double> MyValueChanged;

        #endregion

        #endregion

        #region Constructors (ctor)
        public MyClass()
        {

        }
        public MyClass(string myParameter)
            : base("input for abstract class")
        {
            this.myField = myParameter;
            this.myGetPrivateSet = myParameter;
            this.myReadonly = myParameter;
        }
        public MyClass(MyStruct myStruct)
            : base(myStruct.A)
        {
            this.myField = myStruct.B;
        }
        #endregion

        #region Methods
        public double MyMethod()
        {
            double product = myAttribute * MyAutoProperty;
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + ": " + myField + ", " + product);
            Type type = typeof(MyClass);
            Type thisType = this.GetType();


            bool compare = type == thisType;

            return product;
        }

        public void TryCatchException()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception exception)
            {
                string m = exception.Message;
                string s = exception.Source;
                MethodBase t = exception.TargetSite;
            }
        }

        public static void MyStaticMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            Console.WriteLine(myStaticProperty);

        }

        public void MyInterfaceAMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        public void MyInterfaceBMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
        public new string MyNewMethod()
        {
            string msg = $"{MethodBase.GetCurrentMethod().Display()}";
            Console.WriteLine(msg);

            return msg;
        }
        public void SetField(string value)
        {
            this.myField = value;
        }
        public string GetField() => this.myField;

        public void SetStaticProperty(string value)
        {
            myStaticProperty = value;
        }
        public void SetBaseStaticProperty(string value)
        {
            _myStaticProperty = value;
        }

        internal void ToConsole()
        {
            Console.WriteLine(myField + ", " + myProtectedVariable + " Class!");
        }

        public string GetStaticProperty()
        {
            return myStaticProperty;
        }
        public string GetBaseStaticProperty()
        {
            return _myStaticProperty;
        }

        //concrete implementation of abstract method
        public override void _MyPublicAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
        protected override void _MyProtectedAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }

        //Reflection -> can get methodbase of this function from outside this class
        public RuntimeMethodHandle GetRuntimeMethodHandle()
        {
            return MethodBase.GetCurrentMethod().MethodHandle;
        }
        //readonly cant be changed
        //public void ChangeReadOnly(string value)
        //{
        //    this.myReadonly = value;
        //}
        public void ChangeGetPrivateSet(string value)
        {
            this.myGetPrivateSet = value;
        }

        #endregion

        #endregion
    }

    public class MyClassB : _MyAbstractClass
    {
        public MyClassB(string field) : base(field)
        {
        }

        public void SetBaseStaticProperty(string value)
        {
            _myStaticProperty = value;
        }
        public string GetBaseStaticProperty()
        {
            return _myStaticProperty;
        }

        protected override void MyProtectedVirtualMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
        protected override void _MyProtectedAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
        public override void _MyPublicAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
    }
}
