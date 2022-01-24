using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;

namespace MyLibrary.MyJSON
{
    internal class DeSerialization
    {
        public static IPath path = IPath.Factory.CreatePathExt(@"myJSONFile.json");
        public static void SerializeJsonWriter(University university)
        {
            var serializer = new JsonSerializer();
            using (var streamW = new StreamWriter(path.FullPath))
            using (JsonWriter writer = new JsonTextWriter(streamW))
            {
                serializer.Serialize(writer, university);
            }
        }

        public static void DeserializeJsonReader()
        {
            var serializer = new JsonSerializer();

            using (TextReader txtReader = new StringReader(path.FullPath))
            using (JsonReader jReader = new JsonTextReader(txtReader))
            {
                University result = serializer.Deserialize<University>(jReader);

                foreach (var student in result.students)
                {
                    Console.WriteLine("Student: " + student.name);
                }

                IDictionary dict = serializer.Deserialize<IDictionary>(jReader);

                foreach (DictionaryEntry entry in dict)
                {
                    Console.WriteLine(string.Format("Key: {0}, Value: {1}", entry.Key, entry.Value));

                }

            }
        }
    }
}
