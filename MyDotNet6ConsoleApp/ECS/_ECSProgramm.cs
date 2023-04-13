using MyLibrary_DotNETstd_2_1;

namespace MyDotNet6ConsoleApp.ECS
{
    public class ECSProgramm : IProgram
    {
        public void Run()
        {
            var examples = new Examples(
                new ECSExample());

            examples.Execute();
        }
    }
}
