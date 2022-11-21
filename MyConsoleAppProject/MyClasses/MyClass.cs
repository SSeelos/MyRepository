using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyClass : MyAbstractClass, IMyInterfaceA, IMyIntefaceB
    {
        //fields        (private :accessibility within the same class)
        private string myField;

        //attributes    (public: accessible by any code within current or external assembly)
        public double myAttribute = 1;

        //property: field with get/set block
        public int myProperty { get; set; }

        //all instances of the class share static properties
        public static string myStaticProperty { get; set; }

        #region advanced Property
        public double Min;
        public double Max;
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

        //methods
        public double MyMethod()
        {
            double product = myAttribute * myProperty;
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + ": " + myField + ", " + product);
            Type type = typeof(MyClass);
            Type thisType = this.GetType();

            try
            {
                throw new Exception();
            }
            catch (Exception exception)
            {
                string m = exception.Message;
                string s = exception.Source;
                MethodBase t = exception.TargetSite;

                throw;
            }
            bool compare = type == thisType;

            return product;
        }


        public static void MyStaticMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            Console.WriteLine(myStaticProperty);

        }

        public void MyInterfaceFunction()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        public void MyInterface2Function()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        //constructor
        public MyClass(string myField = "myValue")
            : base("input for abstract class")
        {
            this.myField = myField;
        }
        public MyClass(MyStruct myStruct)
            : base(myStruct.A)
        {
            this.myField = myStruct.B;
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
        public override void MyPublicAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
        protected override void MyProtectedAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }

        //Reflection -> can get methodbase of this function from outside this class
        public RuntimeMethodHandle GetRuntimeMethodHandle()
        {
            return MethodBase.GetCurrentMethod().MethodHandle;
        }

    }

    public class MyClassB : MyAbstractClass
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
        protected override void MyProtectedAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
        public override void MyPublicAbstractMethod()
        {
            Console.WriteLine($"{GetType().Name} - (override){MethodBase.GetCurrentMethod().Name}");
        }
    }
}
