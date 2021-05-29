using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyClass : IMyInterface, IMyInteface2
    {
        //fields        (private :accessibility within the same class)
        private string myField;

        //attributes    (public: accessible by any code within current or external assembly)
        public double myAttribute = 1;

        //property: field with get/set block
        public int myProperty { get; set; }

        //methods
        public double MyMethod()
        {
            double product = myAttribute * myProperty;
            Console.WriteLine(MethodBase.GetCurrentMethod().Name + ": " + myField + ", " + product);
            return product;

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
        {
            this.myField = myField;
        }

        public void SetField(string value)
        {
            this.myField = value;
        }
    }
}
