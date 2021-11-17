using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNet6ConsoleApp
{
    internal class Lambda
    {
        public Lambda()
        {
            Func<string, int>? parseFunc = (string s) => int.Parse(s);

            //creates new anonymous delegate
            var parse = (ref string s) => int.Parse(s);

            //infer expression from agument types
            Expression parseExp = (string s) => int.Parse(s);

        }
    }
}
