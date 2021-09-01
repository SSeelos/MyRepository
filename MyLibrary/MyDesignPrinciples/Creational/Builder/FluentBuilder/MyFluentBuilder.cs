namespace MyLibrary.MyDesignPrinciples.Builder
{
    #region builder interfaces

    public interface IBuildPartA
    {
        IBuildPartBOrPartC BuildPartA(string partA);
    }
    public interface IBuildPartBOrPartC
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

    #endregion

    public class MyFluentBuilder : IBuildPartA, IBuildPartBOrPartC, IBuildPartC, IGetProduct
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

        #region steps

        public IBuildPartA Start()
        {
            return this;
        }
        public IBuildPartBOrPartC BuildPartA(string partA)
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

        #endregion

        public MyFluentProduct GetProduct()
        {
            var result = this.product;
            Reset();

            return result;
        }
    }
}
