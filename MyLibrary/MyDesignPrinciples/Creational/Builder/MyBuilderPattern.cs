using System.Collections.Generic;

namespace MyLibrary.MyDesignPrinciples.Builder
{
    /// <summary>
    /// Declares product construction steps
    /// </summary>
    public interface IBuilder
    {
        IBuilder BuildPartA();
        IBuilder BuildPartB();
        IBuilder BuildPartC(string partC);
        IBuilder BuildPartProd(List<MyPartProduct> partProducts);
    }

    /// <summary>
    /// Implementations of the construction steps.
    /// May produce products that don’t follow the common interface
    /// </summary>
    public class MyBuilder : IBuilder
    {
        private MyProduct product;
        private string initPart;
        private string newPart;

        public MyBuilder(string initPart, string newPart)
        {
            this.initPart = initPart;
            this.newPart = newPart;
            newProduct(newPart);
        }
        public void newProduct(string newPart)
        {
            this.product = new MyProduct(initPart, newPart);
        }

        #region Production steps

        public IBuilder BuildPartA()
        {
            this.product.Add("PartA");
            return this;
        }
        public IBuilder BuildPartB()
        {
            this.product.Add("PartB");
            return this;
        }
        public IBuilder BuildPartC(string partC)
        {
            this.product.Add(partC);
            return this;
        }

        public IBuilder BuildPartProd(List<MyPartProduct> partProducts)
        {
            this.product.AddPartProducts(partProducts);
            return this;
        }

        #endregion

        public MyProduct GetProduct()
        {
            var result = this.product;

            newProduct(newPart);

            return result;
        }


    }

    /// <summary>
    /// execute building steps in particular sequence (Director is optional)
    /// </summary>
    public class MyDirector
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set => builder = value;
        }

        public void buildVariableProduct()
        {
            builder.BuildPartA();
        }

        public void buildFullProduct(string partC)
        {
            this.builder.BuildPartA()
                .BuildPartB()
                .BuildPartC(partC);
        }
    }
}
