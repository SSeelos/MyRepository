namespace MyLibrary.MyDesignPrinciples.Bridge
{
    class MyBridgeClient
    {
        public static void Run()
        {
            var implementationA = new MyImplementationA();
            var abstraction = new MyAbstraction(implementationA);
            abstraction.FeatureA();
            abstraction.FeatureB();

            var implementationB = new MyImplementationB();
            var subAbstraction = new MySubAbstraction(implementationB);
            subAbstraction.FeatureA();
            subAbstraction.FeatureB();
            subAbstraction.SubFeature();
        }
    }
}
