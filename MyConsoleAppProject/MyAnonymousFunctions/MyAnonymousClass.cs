using System;
using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyAnonymousFunctionsProgram
    {
        public int MyProperty { get => Get(); set => Set(value); }
        public int Set(int value)
        {
            return value;
        }

        public int Get()
        {
            return MyProperty;
        }

        /// <summary>
        /// has an expression as its body
        /// (input-parameters) => expression
        /// </summary>
        public void ExpressionLambda()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            Func<int, int> fct = myParam => myParam * 2;

            var result = fct(2);

            Console.WriteLine(result);
        }
        /// <summary>
        /// has a statement block as its body
        /// (input-parameters) => { <sequence-of-statements> }
        /// </summary>
        public void StatementLambda()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);

            Action<int> action = myParam =>
            {
                int result = myParam * 2;

                Console.WriteLine($"{result}");
            };

            action(2);

        }
        public MyAnonymousFunctionsProgram()
        {
            Console.WriteLine();
            Console.WriteLine("#");
            Console.WriteLine(this.GetType().Name);
            Console.Read();
        }

        public void Run()
        {
            ExpressionLambda();

            StatementLambda();
        }
    }
}
