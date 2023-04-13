using MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Builder;

namespace MyLibrary_DotNETstd_2_1
{
    public interface INestable
    {
        INestableBuilder Nest();
        INestableBuilder Return();
    }
    public interface INestableBuilder : INestable, IBuildPartAOrNest, IBuildPartBOrPartCOrNest, IBuildPartCOrNest, IGetProduct
    {
        IBuildPartAOrNest Build();
    }


    public interface IBuildPartAOrNest : INestable
    {
        IBuildPartBOrPartCOrNest BuildPartA(string partA);
    }
    public interface IBuildPartBOrPartCOrNest : INestable
    {
        IBuildPartCOrNest BuildPartB_Optional(string partB);
        //IGetProduct BuildPartC(string partC);
    }
    public interface IBuildPartCOrNest : INestable
    {
        IGetProduct BuildPartC(string partC);
    }

    public class MyNestedBuilderA : INestableBuilder
    {
        private MyFluentProduct product;
        private INestableBuilder parent;

        public MyNestedBuilderA()
        {
            Reset();
        }
        public void Reset() => this.product = new MyFluentProduct();

        #region Steps
        public INestableBuilder Nest() => new MyNestedBuilderA { parent = this, product = this.product };
        public INestableBuilder Return() => parent;

        public IBuildPartAOrNest Build() => this;

        public IBuildPartBOrPartCOrNest BuildPartA(string partA)
        {
            product.SetPartA(partA);
            return this;
        }

        public IBuildPartCOrNest BuildPartB_Optional(string partB)
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

        public IProduct GetProduct()
        {
            var result = this.product;
            Reset();

            return result;
        }

    }
}
