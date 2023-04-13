using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;

namespace MyLibrary_DotNETstd_2_1.MyJSON
{
    public class MyJsonConvertEx : IExample
    {
        IPath path;
        ClassToSerialize university;
        public MyJsonConvertEx(IPath path, ClassToSerialize university)
        {
            this.path = new PathExt(path);
            this.path.FileName += "Convert";
            this.university = university;
        }
        public void Execute()
        {
            SerializeJSON(path, university);

            DeserializeJSON(path);
        }

        public static string SerializeJSON(IPath path, ClassToSerialize toSerialize)
        {
            string stringJson = JsonConvert.SerializeObject(toSerialize, Formatting.Indented);

            File.WriteAllText(path.FullPath, stringJson);
            Console.WriteLine("Write: \n" + stringJson);
            return stringJson;
        }

        public static void DeserializeJSON(IPath path)
        {
            var stringJson = File.ReadAllText(path.FullPath);
            Console.WriteLine("Read: \n" + stringJson);
            ClassToSerialize deserializedObject = JsonConvert.DeserializeObject<ClassToSerialize>(stringJson);

            Console.WriteLine("DeserializedUni: " + deserializedObject.name);
            foreach (var part in deserializedObject.partOfList)
            {
                Console.WriteLine("Student: " + part.name);
            }

            IDictionary dict = JsonConvert.DeserializeObject<IDictionary>(stringJson);

            foreach (DictionaryEntry entry in dict)
            {
                Console.WriteLine(string.Format("Key: {0}, Value: {1}", entry.Key, entry.Value));
            }
        }
    }
}
