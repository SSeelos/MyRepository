using System;
using System.IO;

namespace MyLibrary_DotNETstd_2_1
{
    public class GetFilesEx : IExample
    {
        public void Execute()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var files = Directory.GetFiles(path);
            var filesAll = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(Path.GetDirectoryName(file));
                Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));

                var info = new FileInfo(file);
                Console.WriteLine(info.FullName);
                Console.WriteLine(info.Length);
                Console.WriteLine(info.CreationTimeUtc);
            }
        }
    }
}
