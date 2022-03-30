using System;
using System.IO;

namespace MyLibrary_DotNETstd_2_1
{
    public interface IDirectory
    {
        string Directory { get; set; }
        bool DirectoryExists { get; }

        IDirectory CreateDirectory();
        void DeleteDirectory();
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
        void Delete();
    }
    public class DirectoryExt : IDirectory
    {
        public string Directory { get; set; }

        public bool DirectoryExists => System.IO.Directory.Exists(Directory);

        public IDirectory CreateDirectory()
        {
            System.IO.Directory.CreateDirectory(Directory);
            return this;
        }

        public void DeleteDirectory()
        {
            if (DirectoryExists)
                System.IO.Directory.Delete(Directory);
        }
    }
    public class PathExt : IPath
    {
        public string Directory { get; set; }
        public string FileName { get; set; }
        public string DirectoryFileName => Path.Combine(Directory, FileName);
        public string Extension { get; set; }

        public string FullPath => DirectoryFileName + Extension;

        public bool Exists => File.Exists(FullPath);

        public bool DirectoryExists => System.IO.Directory.Exists(Directory);

        public PathExt()
        {

        }
        public PathExt(IPath path)
            : this(path.FullPath)
        {

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

        public IDirectory CreateDirectory()
        {
            System.IO.Directory.CreateDirectory(Directory);
            return this;
        }

        public void Delete()
        {
            if (Exists)
                File.Delete(FullPath);
        }
        public void DeleteDirectory()
        {
            if (DirectoryExists)
                System.IO.Directory.Delete(Directory);
        }
    }
}
