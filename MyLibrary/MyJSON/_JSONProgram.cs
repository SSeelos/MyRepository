using System.Collections.Generic;

namespace MyLibrary.MyJSON
{
    public class JSONProgram : IProgram
    {
        public static IPath path = IPath.Factory.CreatePathExt(@"myJSONFile.json");
        public void Run()
        {
            var university = new University();
            InitUniversity(university);

            MyJsonConvert.SerializeJSON(path,university);
            DeSerialization.SerializeJsonWriter(university);

            MyJsonConvert.DeserializeJSON(path);
            DeSerialization.DeserializeJsonReader();
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


    }
}
