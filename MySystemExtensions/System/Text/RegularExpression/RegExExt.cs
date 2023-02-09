using System.Text.RegularExpressions;

namespace MySystemExtensions
{
    public class RegExExt
    {
        public static class Pattern
        {
            public const string AnonymousMethodName = @"<(\w|_)+>b_.+";
            //https://regex101.com/r/TTbb2Q/1
            //  /.*\.\d+.r(vt|fa)$/gm
            public const string RevitBackupFile = @".*\.\d+.r(vt|fa)$";
        }

        public static Regex AnonymousMethodName => new Regex(Pattern.AnonymousMethodName);
        public static Regex RevitBackupFile => new Regex(Pattern.RevitBackupFile);
    }
}
