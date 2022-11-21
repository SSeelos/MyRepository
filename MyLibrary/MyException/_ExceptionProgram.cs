namespace MyLibrary_DotNETstd_2_1
{
    public class ExceptionProgram : IProgram
    {
        public void Run()
        {
            var examples = new Examples(
                new ExceptionEx(),
                new ExceptionExNested(),
                new ExceptionExNestedB());

            examples.Execute();
        }
    }
}
