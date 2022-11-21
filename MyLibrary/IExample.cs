using System;
using System.Collections.Generic;

namespace MyLibrary_DotNETstd_2_1
{
    public interface IExample
    {
        void Execute();
    }

    public class Examples : IExample
    {
        IEnumerable<IExample> examples;

        public Examples(params IExample[] examples)
        {
            this.examples = examples;
        }
        public void Execute()
        {
            foreach (var example in examples)
            {
                Console.WriteLine($"Example:{example.GetType().Name}");
                example.Execute();
                Console.WriteLine();
            }
        }
    }
}
