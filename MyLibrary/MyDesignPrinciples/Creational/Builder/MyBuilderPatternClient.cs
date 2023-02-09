using System;

namespace MyLibrary_DotNETstd_2_1.MyDesignPrinciples.Builder
{
    class MyBuilderPatternClient
    {
        public static void Run()
        {
            var builder = new MyBuilder("initPart", "firstPart");
            var director = new MyDirector() { Builder = builder };

            BuildProductWithBuilder(builder);

            BuildWithDirector(director);

            BuildWithPartBuilder();

            BuildWithFluentBuilder();

            BuildWithNestedBuilder();

        }
        private static void BuildProductWithBuilder(MyBuilder builder)
        {

            builder.BuildPartA()
                .BuildPartB()
                .BuildPartC("partC");

            MyProduct product = builder.GetProduct();
            var parts = product.OutputParts();
            Console.WriteLine(parts);


            builder.newProduct("secondPart");
            builder.BuildPartA();

            MyProduct newProd = builder.GetProduct();
            parts = newProd.OutputParts();
            Console.WriteLine(parts);
        }

        private static void BuildWithDirector(MyDirector director)
        {
            director.buildVariableProduct();
            director.buildFullProduct("part C");
        }

        private static void BuildWithPartBuilder()
        {
            var builder = new MyPartBuilder("initPart");
            var director = new MyPartDirector() { Builder = builder };

            director.buildFullPartProduct("partC");

            var prod = builder.GetProduct();
            var parts = prod.OutputParts();
            Console.WriteLine(parts);
        }

        private static void BuildWithFluentBuilder()
        {
            var builder = new MyFluentBuilder();
            IBuildPartA start = builder.Start();
            IBuildPartBOrPartC A = start.BuildPartA("A");
            IBuildPartC B = A.BuildPartB_Optional("B (optional)");
            IGetProduct C = B.BuildPartC("C");

            IProduct prod = C.GetProduct();
            var parts = prod.OutputParts();
            Console.WriteLine(parts);


            IProduct prod2 = builder.Start()
                .BuildPartA("A2")
                .BuildPartC("C2")
                .GetProduct();

            Console.WriteLine(prod2.OutputParts());

        }

        private static void BuildWithNestedBuilder()
        {
            var builder = new MyNestedBuilderA();
            IBuildPartAOrNest build = builder.Build();
            IBuildPartBOrPartCOrNest A = build.BuildPartA("A");
            IBuildPartCOrNest B = A.BuildPartB_Optional("B");
            IBuildPartAOrNest nest = B.Nest().Build();
            IBuildPartBOrPartCOrNest An = nest.BuildPartA("nestedA");
            IBuildPartCOrNest Bn = An.BuildPartB_Optional("nestedB");
            INestableBuilder ret = Bn.Return();
            IGetProduct C = ret.BuildPartC("C");
            IProduct product = C.GetProduct();
            ;
            var parts = product.OutputParts();
            Console.WriteLine(parts);


            var builder2 = new MyNestedBuilderA();
            IProduct product2 = builder2.Build()
                .BuildPartA("A")
                .BuildPartB_Optional("B")
                    .Nest().Build()
                    .BuildPartA("nestedA")
                    .BuildPartB_Optional("nestedB")
                    .Return()
                .BuildPartC("C")
                .GetProduct();
            var parts2 = product2.OutputParts();
            Console.WriteLine(parts2);
        }
    }
}
