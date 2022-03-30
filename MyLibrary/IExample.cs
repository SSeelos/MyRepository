﻿using System;
using System.Collections.Generic;
using System.Text;

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
                example.Execute();
            }
        }

    }
}
