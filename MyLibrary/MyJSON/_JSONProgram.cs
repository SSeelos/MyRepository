using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace MyLibrary.MyJSON
{
    public class JSONProgram : IProgram
    {
<<<<<<< HEAD:MyLibrary/MyJSON/JSONProgram.cs
        public static string fileName = "myJSONFile.json";
        public static string filePath = MyPaths.Directory + "\\" + fileName;
        public static void Run()
=======
        public static string fileName = @"myJSONFile.json";
        public void Run()
>>>>>>> 4579333d76d523225eca9a5dcd5f9fec77685720:MyLibrary/MyJSON/_JSONProgram.cs
        {
            var university = new University();
            InitUniversity(university);

            SerializeJSON(university);

            DeserializeJSON();
        }

        private static void InitUniversity(University university)
        {
            university.name = "South Carolina StateUniversity";

            List<Student> listStudent = new List<Student>();
            var student1 = new Student
            {
                id = 0,
                name = "Stephen Cousins"
            };
            var student2 = new Student
            {
                id = 1,
                name = "Austin A. Newton"
            };
            var student3 = new Student
            {
                id = 2,
                name = "Adam Wilhite"
            };
            var student4 = new Student
            {
                id = 3,
                name = "Enis Kurtay YILMAZ"
            };

            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            university.students = listStudent;
        }

        private static string SerializeJSON(University university)
        {
            string stringJson = JsonConvert.SerializeObject(university);

            File.WriteAllText(filePath, stringJson);
            Console.WriteLine("Write: \n" + stringJson);
            return stringJson;
        }
        private static void DeserializeJSON()
        {
            var stringJson = File.ReadAllText(filePath);
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

    }
}
