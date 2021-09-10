using System;
using System.Collections.Generic;

namespace MyConsoleAppProject
{
    class MyDebugging
    {
        public static void Run()
        {
            #region 1. DataTip            
            //When stopped in the debugger hover the mouse cursor over the variable you want to look at
            var myString = "Hello String!";
            Console.WriteLine(myString);

            //You can also “pin” a DataTip to your code by clicking on the pin icon next to a value.
            var myArray = new string[] { "Hello", " ", "Array", "!" };
            for (var i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]);

                if (i == myArray.Length - 1)
                {
                    Console.WriteLine();
                }
            }
            #endregion

            #region 2. Autos Window
            //As you stop at different places in your code the Autos window will automatically populate with all the variables used in the current statement
            //Open up this window from Debug/Windows/Autos Window (Ctrl+Alt+V, A)
            var myList = new List<string> { "H", "e", "l", "l", "o", " ", "L", "i", "s", "t", "!" };
            foreach (var s in myList)
            {
                Console.Write(s);
            }
            Console.WriteLine();
            #endregion

            #region 3. Locals Window
            //The Locals window will populate with the local variables for the current method
            //(in the local scope of your current stack frame)
            //Open up this window from Debug/Windows/Locals Window (Ctrl+Alt+V, L)

            var myStruct = new MyStruct("Hello", "Struct!");
            myStruct.ToConsole();
            #endregion

            #region 4. Watch Windows
            //These windows start out blank and let you add the names of variables that you care about watching as you debug your application.

            var myClass = new MyClass(myStruct);
            myClass.ToConsole();

            #endregion



        }
    }
}

