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

        class MorseCodeDecoder
        {

            public static string Decode(string morseCode)
            {
                string tempCode = string.Empty;
                string decodedMessage = string.Empty;

                foreach (char ch in morseCode)
                {

                    bool v = ch == " ";
                    if (v)
                    {
                        string tempMessage = MorseCode.Get(tempCode);

                        decodedMessage.Concat(tempMessage);
                    }

                    tempCode.Concat(ch.ToString());
                }

                return decodedMessage;

            }
            private static string[] GetStrings(string code, char ch)
            {
                var indicies = FindCharIndicies(code, ch);

                foreach (int index in indicies)
                {

                }
            }
            private static int[] FindCharIndicies(string code, char ch)
            {
                char cha = ' ';
                int count = CountChar(code, ch);
                int[] indicies = new int[count];


                for (int i = 0; i < count + 1; i++)
                {
                    indicies[i] = code.IndexOf(ch);
                };

                return indicies;
            }

            private static int CountChar(string code, char ch)
            {
                int counter = 0;
                int index = 0;
                while (index >= 0)
                {
                    index = code.IndexOf(ch, index + 1);
                    counter++;
                }

                return counter;
            }
        }
    }
}
