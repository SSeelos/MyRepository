using System.IO;
using System.Reflection;

namespace MyLibrary
{
    public class MyPaths
    {
        public static string AssemblyPath { get => Assembly.GetExecutingAssembly().Location; }
        public static string Directory { get => Path.GetDirectoryName(AssemblyPath); }
    }
}
