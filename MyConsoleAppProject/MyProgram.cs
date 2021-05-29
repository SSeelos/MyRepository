using MyConsoleAppProject.MyEventsAndDelegates;
using System;
using System.Linq;

namespace MyConsoleAppProject
{
    public class MyProgram
    {
        enum MyEnum
        {
            first,
            second,
            third
        }

        static void Main(string[] args)
        {
            //method /function)
            int myArgument = 0;
            myArgument = MyMethod(myArgument);


            //casting
            Casting();

            #region arrays, matrix
            var myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }

            Console.WriteLine($"array: {myArray[2]}");

            var myMatrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    myMatrix[i, j] = i + j;
                    Console.WriteLine($"matrix: {myMatrix[i, j]}");
                }
            }
            #endregion

            #region if, while, for, foreach, switch
            //if

            if (myMatrix[0, 0] >= 0)
            {
                Console.WriteLine("pos");
            }
            else
            {
                Console.WriteLine("neg");
            }

            //while

            while (myArray[9] > 0)
            {
                myArray[9] -= 1;
                Console.WriteLine($"while {myArray[9]}");
            }

            //for

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("for " + i);
            }

            foreach (int i in myArray)
            {
                Console.WriteLine("foreach" + i);
            }

            //switch

            switch (myArray[9])
            {
                case 0:
                    Console.WriteLine("null");
                    break;

                case 1:
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine("none");
                    break;
            }

            var myEnumSelection = MyEnum.first;


            switch (myEnumSelection)
            {
                case MyEnum.first:
                    Console.WriteLine("first");
                    break;
                case MyEnum.second:
                case MyEnum.third:      //two cases treated as "OR"
                    Console.WriteLine("second OR third");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            #endregion

            #region class
            var myObject = new MyClass();
            myObject.myAttribute = 2;
            myObject.MyMethod();
            myObject.MyInterfaceFunction();
            myObject.MyInterface2Function();

            //set property
            myObject.myProperty = 5;
            //get property
            var str = myObject.myProperty;
            #endregion

            #region reference or value

            //Value            
            int a = 1;
            double b = 0.0;

            b = (double)a;
            a = (int)b;

            Console.WriteLine($"a before reference method: {a}");
            ReferenceMethod(ref a);
            Console.WriteLine($"a after reference method: {a}");

            int c;
            OutMethod(out c);


            #endregion

            #region LINQ
            //1. data source
            var source = new int[3] { 1, 2, 3 };
            //2. Query
            var numQ = from num in source
                       where num < 2
                       select num;


            var numQuery = from num in source
                           where num > 1
                           select num;
            //3. execute
            foreach (int num in numQ)
            {
                Console.WriteLine("Q" + num);
            }

            foreach (int num in numQuery)
            {
                Console.Write("Query {0,1}", num);
            }

            #endregion

            #region generics
            var generic = new MyGenericClass();
            var myInt = 0;
            var myInt2 = 2;
            var myIntArray = generic.CreateArray(myInt, myInt2);
            var myString = "first";
            var myString2 = "second";
            var myStringArray = generic.CreateArray(myString, myString2);
            #endregion

            #region EventsAndDelegates
            new MyEventsProgram()
                .Run();
            #endregion

            new MyAnonymousFunctionsProgram()
                .Run();
        }

        public static int MyMethod(int myArgument)
        {
            myArgument += 1;
            return myArgument;
        }

        public static void ReferenceMethod(ref int reference)
        {
            reference += reference;
        }

        public static void OutMethod(out int o)
        {
            o = 4;
        }

        public static void Casting()
        {
            double myDouble = 2.3;
            int myResult = 0;

            myResult = (int)myDouble;

            Console.WriteLine($"Res: {myResult}");
        }
    }
}

