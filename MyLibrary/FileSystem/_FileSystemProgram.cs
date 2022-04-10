namespace MyLibrary_DotNETstd_2_1
{
    public class FileSystemProgram : IProgram
    {
        public void Run()
        {
            var examples = new Examples(
                new GetDirectoriesEx(),
                new GetFilesEx());

            examples.Execute();
        }
    }
}
