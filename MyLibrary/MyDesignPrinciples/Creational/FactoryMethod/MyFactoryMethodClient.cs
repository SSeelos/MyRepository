namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.FactoryMethod
{
    class MyFactoryMethodClient
    {
        public static void Run()
        {
            var creatorDef = new MyCreatorDefault();
            creatorDef.Operation();

            var creatorA = new MyCreatorA();
            creatorA.Operation();

            var creatorB = new MyCreatorB();
            creatorB.Operation();

        }
    }
}
