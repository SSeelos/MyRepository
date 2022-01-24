using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;

namespace MyLibrary.MyJSON
{
    public class MyJsonConvert
    {
        public static void DeserializeJSON(IPath path)
        {
            path.FileName += "Convert";
            var stringJson = File.ReadAllText(path.FullPath);
            Console.WriteLine("Read: \n" + stringJson);
            University deserializedUni = JsonConvert.DeserializeObject<University>(stringJson);

            Console.WriteLine("DeserializedUni: " + deserializedUni.name);
            foreach (var student in deserializedUni.students)
            {
                Console.WriteLine("Student: " + student.name);
            }

            IDictionary dict = JsonConvert.DeserializeObject<IDictionary>(stringJson);

            foreach (DictionaryEntry entry in dict)
            {
                Console.WriteLine(string.Format("Key: {0}, Value: {1}", entry.Key, entry.Value));
            }
        }
        public static string SerializeJSON(IPath path, University university)
        {
            string stringJson = JsonConvert.SerializeObject(university);

            path.FileName += "Convert";
            File.WriteAllText(path.FullPath, stringJson);
            Console.WriteLine("Write: \n" + stringJson);
            return stringJson;
        }
    }
}
