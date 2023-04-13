using System;
using System.IO;
using System.Reflection;

namespace MyLibrary_DotNETstd_2_1
{
    public class GetDirectoriesEx : IExample
    {
        public void Execute()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            string dir = Path.GetDirectoryName(path);
            var dirs = Directory.GetDirectories(dir);

            foreach (var d in dirs)
            {
                Console.WriteLine(d);
            }

            var dirsOp = Directory.GetDirectories(dir,"*",SearchOption.AllDirectories);

            foreach (var d in dirs)
            {
                Console.WriteLine(d);
            }
        }
    }
}
