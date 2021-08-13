using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.MyDesignPrinciples.MyBuilderPattern
{
    public interface IBuildPartA
    {
        IBuildPartOptional BuildPartA(string partA);
    }
    public interface IBuildPartOptional
    {
        IBuildPartC BuildPartB(string partB);
    }
    public interface IBuildPartC
    {
        IBuildProduct BuildPartC(string partC);
    }
    public interface IBuildProduct
    {
        MySequentialProduct GetProduct();
    }

    public class MySequentialBuilder : IBuildPartA, IBuildPartOptional, IBuildPartC, IBuildProduct
    {
        private MySequentialProduct product;

        public MySequentialBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            this.product = new MySequentialProduct();
        }
        public IBuildPartA Start()
        {
            return this;
        }
        public IBuildPartOptional BuildPartA(string partA)
        {
            product.SetPartA(partA);
            return this;
        }

        public IBuildPartC BuildPartB(string partB)
        {
            product.SetPartB(partB);
            return this;
        }

        public IBuildProduct BuildPartC(string partC)
        {
            product.SetPartC(partC);
            return this;
        }

        public MySequentialProduct GetProduct()
        {
            var result = this.product;
            Reset();

            return result;
        }
    }
}
