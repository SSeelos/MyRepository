using System;
using System.Text;

namespace MyLibrary_DotNETstd_2_1
{
    internal class MyEncodingExample : IExample
    {
        public void Execute()
        {
            string unicodePI = "\u03a0";
            string unicodePlusMinus = "\u00B1";
            //Encoding utf8 = Encoding.UTF8;
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;


            byte[] uniBytes = unicode.GetBytes(unicodePI);

            byte[] asciiBytes = Encoding.Convert(unicode, ascii, uniBytes);

            char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string aciiStr = new string(asciiChars);

            Console.WriteLine($"Unicode: {unicodePI}");
            Console.WriteLine($"Unicode: {unicodePlusMinus}");
            Console.WriteLine($"ACII: {aciiStr}");


        }
    }
}
