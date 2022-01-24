using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyLibrary
{
    public interface IDirectory
    {
        string Directory { get; set; }
    }
    public interface IFileName
    {
        string FileName { get; set; }
    }
    public interface IExtension
    {
        string Extension { get; set; }
    }
    public interface IPath : IDirectory, IFileName, IExtension
    {
        string DirectoryFileName { get; }
        string FullPath { get; }
        bool Exists { get; }
        bool DirectoryExists { get; }
        public static class Factory
        {
            public static IPath CreatePathExt(string path) => new PathExt(path);
        }
        public void CreateDirectory();
    }

    public class PathExt : IPath
    {
        public string Directory { get; set; }
        public string FileName { get; set; }
        public string DirectoryFileName => Path.Combine(Directory, FileName);
        public string Extension { get; set; }

        public string FullPath => DirectoryFileName + Extension;

        public bool Exists => File.Exists(FullPath);
        public bool DirectoryExists => System.IO.Directory.Exists(FullPath);
        public PathExt()
        {

        }
        public PathExt(IPath path)
        {
            var pathFull = path.FullPath;
            Directory = Path.GetDirectoryName(pathFull);
            FileName = Path.GetFileNameWithoutExtension(pathFull);
            Extension = Path.GetExtension(pathFull);

        }
        public PathExt(string path)
        {
            Directory = Path.GetDirectoryName(path);
            FileName = Path.GetFileNameWithoutExtension(path);
            Extension = Path.GetExtension(path);
        }

        public void AddTimeStamp()
        {
            FileName += DateTime.Now.ToString("dd-MM");
        }
        public void CreateDirectory()
        {
            if (DirectoryExists)
            {
                return;
            }
            System.IO.Directory.CreateDirectory(FullPath);
        }
    }
}
