namespace MyLibrary_DotNETstd_2_1
{
    public class MyEncodingProgram : IProgram
    {
        public void Run()
        {
            var examples = new Examples(
                new MyEncodingExample());

            examples.Execute();
        }
    }
}
