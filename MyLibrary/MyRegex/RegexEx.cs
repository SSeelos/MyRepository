using System;
using System.Text.RegularExpressions;

namespace MyLibrary_DotNETstd_2_1
{
    /// <summary>
    /// Use the methods of the System.String class when you are searching for a specific string.
    /// Use the Regex class when you are searching for a specific pattern in a string
    /// 
    /// \b	        Start the match at a word boundary.
    ///(?<group>\w+)	Match one or more word characters up to a word boundary.Name this captured group word.
    ///\s+	        Match one or more white-space characters.
    ///(\k<group>)	Match the captured group that is named word.
    ///\b           Match a word boundary.
    /// </summary>
    public class RegexEx : IExample
    {
        public void Execute()
        {
            var regexEx = new Regex(@"\b(?<group>\w+)\s+(\k<group>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            string testStr = "jo jo Jo JO JOjoHeyHey hey hey";
            string text = "The the quick brown fox  fox jumps over the lazy dog dog.";
            MatchCollection matches = regexEx.Matches(text);
            MatchCollection matches2 = regexEx.Matches(testStr);

            Console.WriteLine(matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);

                GroupCollection groups = match.Groups;
                Group group = groups["group"];
                CaptureCollection captures = group.Captures;

                Console.WriteLine($"Group: {group.Value}, repeated at {groups[0].Index} & {groups[1].Index}");
            }


        }
    }
}
