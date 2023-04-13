
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary_DotNETstd_2_1;
using System;
using System.IO;



namespace MyLibraryTests.Tests
{
    [TestClass()]
    public class PathExtTests
    {
        private static string testPath = @"C:\Temp\TestDirectory\TestFile.txt";
        private PathExt Generate()
        {
            return new PathExt()
            {
                Directory = @"C:\Temp\TestDirectory",
                FileName = "TestFile",
                Extension = ".txt"
            };

        }
        private IPath GenerateTxtFile()
        {
            var path = Generate();

            path.CreateDirectory();

            using (var sw = new StreamWriter(path.FullPath))
            {
                sw.Write("");
            }

            return path;
        }
        private IDirectory GenerateDirectory()
        {
            var path = Generate();

            return path.CreateDirectory();

        }

        [TestMethod()]
        public void CreatePathExtTest()
        {
            var path = Generate();

            Assert.AreEqual(testPath, path.FullPath);
        }

        [TestMethod()]
        public void CreatePathExtFromStringTest()
        {
            var path = new PathExt(testPath);

            Assert.IsNotNull(path);
            Assert.AreEqual(@"C:\Temp\TestDirectory", path.Directory);
            Assert.AreEqual("TestFile", path.FileName);
            Assert.AreEqual(".txt", path.Extension);
        }
        [TestMethod()]
        public void CreateDirectoryTest()
        {
            var path = GenerateDirectory();

            var check = path.DirectoryExists;

            Assert.AreEqual(true, check);

            path.DeleteDirectory();

            Assert.AreEqual(false, path.DirectoryExists);
        }

        [TestMethod()]
        public void CheckFileTest()
        {
            var path = GenerateTxtFile();

            var check = path.Exists;

            Assert.AreEqual(true, check);

            path.Delete();
        }

        [TestMethod()]
        public void CheckDirectoryTest()
        {
            var path = GenerateTxtFile();

            var check = path.DirectoryExists;

            Assert.AreEqual(true, check);

            path.Delete();
            path.DeleteDirectory();

            Assert.AreEqual(false, path.DirectoryExists);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var path = GenerateTxtFile();

            Assert.AreEqual(true, path.Exists);

            path.Delete();

            Assert.AreEqual(false, path.Exists);
        }

        [TestMethod()]
        public void CheckDirectoryFailTest()
        {
            var path = Generate();

            path.Directory += "test";
            var check = path.DirectoryExists;

            Assert.AreEqual(false, check);
        }

        [TestMethod()]
        public void ChangeDirectoryTest()
        {
            var path = Generate();

            path.Directory += "A";

            Assert.AreEqual(@"C:\Temp\TestDirectoryA\TestFile.txt", path.FullPath);
        }

        [TestMethod()]
        public void FullPathTest()
        {
            var path = Generate();

            Assert.AreEqual(@"C:\Temp\TestDirectory\TestFile.txt", path.FullPath);
        }

        [TestMethod()]
        public void ChangeFileNameTest()
        {
            var path = Generate();

            path.FileName += "A";

            Assert.AreEqual("TestFileA", path.FileName);
            Assert.AreEqual(@"C:\Temp\TestDirectory\TestFileA.txt", path.FullPath);
        }

        [TestMethod()]
        public void ChangeExtension()
        {
            var path = Generate();

            path.Extension = ".ifc";

            Assert.AreEqual(@"C:\Temp\TestDirectory\TestFile.ifc", path.FullPath);
        }

        [TestMethod()]
        public void AddTimeStampTest()
        {
            var path = Generate();

            path.AddTimeStamp();

            var date = DateTime.Now.ToString("dd-MM");

            Assert.AreEqual(@$"C:\Temp\TestDirectory\TestFile{date}.txt", path.FullPath);
        }
    }
}
