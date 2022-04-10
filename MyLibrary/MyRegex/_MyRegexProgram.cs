namespace MyLibrary_DotNETstd_2_1.MyRegex
{
    public class MyRegexProgram : IProgram
    {
        public void Run()
        {
            var examples = new Examples(
                new RegexEx());

            examples.Execute();
        }
    }
}
