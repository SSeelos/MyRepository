namespace MyLibrary.MyDesignPrinciples.MyBuilderPattern
{
    public interface IPartBuilder
    {
        IPartBuilder BuildSubPartA();
        IPartBuilder BuildSubPartB();
        IPartBuilder BuildSubPartC(string partC);
    }

    public class MyPartBuilder : IPartBuilder
    {
        private MyPartProduct partProduct;
        private string initPart;

        public MyPartBuilder(string initPart)
        {
            this.initPart = initPart;
            Reset();
        }

        private void Reset()
        {
            partProduct = new MyPartProduct(initPart);
        }

        #region Production steps


        public IPartBuilder BuildSubPartA()
        {
            partProduct.Add("SubPartA");

            return this;
        }

        public IPartBuilder BuildSubPartB()
        {
            partProduct.Add("SubPartB");

            return this;
        }

        public IPartBuilder BuildSubPartC(string partC)
        {
            partProduct.Add(partC);

            return this;
        }
        #endregion

        public MyPartProduct GetProduct()
        {
            var result = partProduct;
            Reset();

            return result;
        }
    }
}
