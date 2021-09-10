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

        //methods
        public double MyMethod()
        {
            double product = myAttribute * myProperty;
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + ": " + myField + ", " + product);
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
        public void SetStaticProperty(string value)
        {
            myStaticProperty = value;
        }

        internal void ToConsole()
        {
            Console.WriteLine(myField + ", " + myProtectedVariable + " Class!");
        }

        public string GetStaticProperty()
        {
            return myStaticProperty;
        }

        public override void MyAbstractMethod()
        {
            //concrete implementation
        }
    }
}
