namespace MyLibrary.MyDesignPrinciples.MyBuilderPattern
{
    public interface IBuildPartA
    {
        IBuildPartOptional BuildPartA(string partA);
    }
    public interface IBuildPartOptional
    {
        IBuildPartC BuildPartB_Optional(string partB);
        IGetProduct BuildPartC(string partC);
    }
    public interface IBuildPartC
    {
        IGetProduct BuildPartC(string partC);
    }
    public interface IGetProduct
    {
        MyFluentProduct GetProduct();
    }

    public class MyFluentBuilder : IBuildPartA, IBuildPartOptional, IBuildPartC, IGetProduct
    {
        private MyFluentProduct product;

        public MyFluentBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            this.product = new MyFluentProduct();
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

        public IBuildPartC BuildPartB_Optional(string partB)
        {
            product.SetPartB_Optional(partB);
            return this;
        }

        public IGetProduct BuildPartC(string partC)
        {
            product.SetPartC(partC);
            return this;
        }

        public MyFluentProduct GetProduct()
        {
            var result = this.product;
            Reset();

            return result;
        }
    }
}
