using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.MyBuilderPattern
{
    public class MySequentialProduct:IProduct
    {
        private string partA;
        private string partB;
        private string partOptional;
        private string partC;
        public void SetPartA(string part)
        {
            partA = part;
        }
        public void SetPartB(string part)
        {
            partB = part;
        }
        public void SetPartC(string part)
        {
            partC = part;
        }
        public string OutputParts()
        {
            string str = string.Empty;
            var seperator = ", ";
            str += partA + seperator;
            str += partB + seperator;
            if (partOptional != null)
                str += partOptional + seperator;
            str += partC + seperator;

            return "SequentialProduct parts: " + str + "\n";
        }
    }
}
