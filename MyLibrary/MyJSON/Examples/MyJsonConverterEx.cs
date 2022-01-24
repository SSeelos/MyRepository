using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyLibrary.MyJSON
{
    public class MyJsonConverterEx : IExample
    {
        IPath path;
        ClassToSerialize university;
        public MyJsonConverterEx(IPath path, ClassToSerialize university)
        {
            this.path = new PathExt(path);
            this.path.FileName += "Converter";
            this.university = university;

        }
        public void Execute()
        {
            var converter = new MyJsonConverter();

            SerializerWriteJson(converter, path, university);
            //var jsonStirng = JsonConvert.SerializeObject(university, Formatting.Indented,converter);

            DeserializeReadJson(converter, path, university);
        }

        private void SerializerWriteJson(MyJsonConverter converter, IPath path, ClassToSerialize university)
        {
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            using (var streamW = new StreamWriter(path.FullPath))
            using (JsonWriter writer = new JsonTextWriter(streamW))
            {
                converter.WriteJson(writer, university, serializer);
            }
        }
        private void DeserializeReadJson(MyJsonConverter converter, IPath path, ClassToSerialize university)
        {
            var serializer = new JsonSerializer();

            using (TextReader txtReader = new StringReader(path.FullPath))
            using (JsonReader jReader = new JsonTextReader(txtReader))
            {
                var result = (ClassToSerialize)converter.ReadJson(jReader, typeof(ClassToSerialize), university, serializer);
                //University result = serializer.Deserialize<University>(jReader);

                foreach (var part in result.partOfList)
                {
                    Console.WriteLine("Student: " + part.name);
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
