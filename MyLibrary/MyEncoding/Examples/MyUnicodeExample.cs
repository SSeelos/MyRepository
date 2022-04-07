using NeoSmart.Unicode;
using System;
using System.Collections.Generic;
using Unidecode.NET;

namespace MyLibrary_DotNETstd_2_1.MyEncoding
{
    /// <summary>
    /// https://github.com/neosmart/unicode.net
    /// </summary>
    internal class MyUnicodeExample : IExample
    {
        public void Execute()
        {
            string pi = MyEncodingProgram.unicodePI;
            string ascii = pi.Unidecode();

            //direct mapping between any .NET string and the underlying Unicode codepoints
            IEnumerable<Codepoint> cPoints = pi.Codepoints();

            //safe way to decompose a string into its individual letters
            IEnumerable<string> letters = pi.Letters();

            //str.Letters() and str.Codepoints() can be considered as (and, in fact, are)
            //different representations of the same data

            SingleEmoji man = Emoji.OlderPerson;
            SingleEmoji plus = Emoji.Plus;
            Console.WriteLine(man.Sequence.AsString);
            Console.WriteLine(plus.Sequence.AsUtf16());
        }
    }
}
