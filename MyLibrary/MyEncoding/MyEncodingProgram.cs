

namespace MyLibrary_DotNETstd_2_1.MyEncoding
{
    public class MyEncodingProgram : IProgram
    {
        public static string unicodePI = "\u03a0";
        public static string unicodePlusMinus = "\u00B1";
        public void Run()
        {
            var examples = new Examples(
                new MyEncodingExample(),
                new MyUnicodeExample());

            examples.Execute();
        }
    }
}
