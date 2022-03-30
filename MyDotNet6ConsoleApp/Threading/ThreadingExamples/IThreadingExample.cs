using MyLibrary_DotNETstd_2_1.MyUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNet6ConsoleApp.Threading
{
    public interface IThreadingExample
    {
        void Execute();
    }

    public class ThreadingExamples : IThreadingExample
    {
        IThreadingExample[] examples;
        public ThreadingExamples(params IThreadingExample[] example)
        {
            examples = example;
        }

        public void Execute()
        {
            foreach (var example in examples)
            {
                example.Execute();
            }
        }
    }
}
