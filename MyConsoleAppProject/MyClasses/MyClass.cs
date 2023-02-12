using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyClass : MyAbstractClass, IMyInterfaceA, IMyInterfaceB, IMyDuplicateA, IMyDuplicateB
    {
        //fields        (private :accessibility within the same class)
        private string myField;

        //attributes    (public: accessible by any code within current or external assembly)
        public double myAttribute = 1;

        //property: field with get/set block
        public int myProperty { get; set; }

        //all instances of the class share static properties
        public static string myStaticProperty { get; set; }


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

        #region Interfaces
        public void MyInterfaceAMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
        void IMyInterfaceA.MyVirtualInterfaceMethod()
        {
            //...
        }

        public void MyInterfaceBMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }

        /// <summary>
        /// this fulfills both IMyDuplicateA and IMyDuplicateB with the same behaviour
        /// </summary>
        public void MyDuplicateMethod()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// this fulfills only IMyDuplicateA but has to be called explicitly
        /// </summary>
        void IMyDuplicateA.MyDuplicateMethod()
        {
            Console.WriteLine(nameof(IMyDuplicateA), MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// this fulfills only IMyDuplicateB but has to be called explicitly
        /// </summary>
        void IMyDuplicateB.MyDuplicateMethod()
        {
            Console.WriteLine(nameof(IMyDuplicateB) + MethodBase.GetCurrentMethod().Name);
        }
        #endregion

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
