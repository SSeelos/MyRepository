namespace MyLibrary.MyDesignPrinciples.Builder
{
    public class MyPartDirector
    {
        private IPartBuilder builder;

        public IPartBuilder Builder
        {
            set => builder = value;
        }

        public void BuildViablePartProduct()
        {
            builder.BuildSubPartA();
        }

        public void buildFullPartProduct(string partC)
        {
            builder.BuildSubPartA()
                .BuildSubPartB()
                .BuildSubPartC(partC);
        }
    }
}
