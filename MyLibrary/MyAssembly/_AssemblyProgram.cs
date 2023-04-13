namespace MyLibrary_DotNETstd_2_1.MyAssembly
{
    public class AssemblyProgram : IProgram
    {
        public void Run()
        {
            var examples = new Examples(
                new AssemblyEx());

            examples.Execute();
        }
    }
}
