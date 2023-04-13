using Newtonsoft.Json;
using System;
using System.Collections;
using System.IO;

namespace MyLibrary_DotNETstd_2_1.MyJSON
{
    internal class MyJsonSerializerEx : IExample
    {
        public IPath path;
        public ClassToSerialize university;
        public MyJsonSerializerEx(IPath path, ClassToSerialize university)
        {
            this.path = new PathExt(path);
            this.path.FileName += "Serializer";
            this.university = university;

        }
        public void Execute()
        {
            SerializeJsonWriter(path, university);

            DeserializeJsonReader(path);
        }
        public void SerializeJsonWriter(IPath path, ClassToSerialize university)
        {
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            using (var streamW = new StreamWriter(path.FullPath))
            using (JsonWriter writer = new JsonTextWriter(streamW))
            {
                serializer.Serialize(writer, university);
            }
        }

        public void DeserializeJsonReader(IPath path)
        {
            var serializer = new JsonSerializer();

            using (TextReader txtReader = new StringReader(path.FullPath))
            using (JsonReader jReader = new JsonTextReader(txtReader))
            {
                //var txt = txtReader.ReadLine();
                //var read = File.ReadAllText(txt);
                var str = jReader.ReadAsString();
                ClassToSerialize result = serializer.Deserialize<ClassToSerialize>(jReader);

                foreach (var student in result.partOfList)
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
