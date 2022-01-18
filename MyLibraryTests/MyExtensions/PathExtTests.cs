using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary.Tests
{
    [TestClass()]
    public class PathExtTests
    {
        public const string Directory = @"C:\Temp";
        public const string Folder = "Temp";
        public const string File = "File";
        public const string Extension = ".txt";
        public PathExt Generate()
        {
            return new PathExt()
            {
                Directory = Directory,
                FileName = File,
                Extension = Extension
            };
        }

        [TestMethod()]
        public void CtorWithPath()
        {
            var p = IPath.Factory.CreatePathExt(Directory + @"\" + File + Extension);

            var result = p.FullPath;
            var resDir = p.Directory;
            var resFile = p.FileName;
            var resExt = p.Extension;

            Assert.AreEqual(result, Directory + @"\" + File + Extension);
            Assert.AreEqual(resDir, Directory);
            Assert.AreEqual(resFile, File);
            Assert.AreEqual(resExt, Extension);
        }

        [TestMethod()]
        public void GetDirectoryTest()
        {
            var p = Generate();

            var result = p.Directory;

            Assert.AreEqual(Directory, result);
        }

        [TestMethod()]
        public void GetFileNameExtensionTest()
        {
            var p = Generate();

            var result = p.FileName;

            Assert.AreEqual(File + Extension, result);
        }

        [TestMethod()]
        public void GetDirectoryFile()
        {
            var p = Generate();

            var result = p.DirectoryFileName;

            Assert.AreEqual(Directory + File, result);
        }

        [TestMethod()]
        public void InitCombineTest()
        {
            Assert.Fail();
        }


        //[TestMethod()]
        //public void GetFolderTest()
        //{
        //    var p = Generate();

        //    var result = p.Folder;

        //    Assert.AreEqual(Folder, result);
        //}
    }
}