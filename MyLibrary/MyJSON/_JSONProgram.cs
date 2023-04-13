using System.Collections.Generic;

namespace MyLibrary_DotNETstd_2_1.MyJSON
{
    public class JSONProgram : IProgram
    {
        public static IPath path = new PathExt()
        {
            FileName = "myJSONFile",
            Extension = ".json"
        };
        public void Run()
        {
            var university = new ClassToSerialize();
            InitUniversity(university);

            var ex = new Examples(
                new MyJsonConvertEx(path, university),
                //new MyJsonSerializerEx(path, university),
                new MyJsonConverterEx(path, university));

            ex.Execute();
        }

        private static void InitUniversity(ClassToSerialize university)
        {
            university.name = "South Carolina StateUniversity";

            List<ClassPartOfList> listStudent = new List<ClassPartOfList>();
            var student1 = new ClassPartOfList
            {
                id = 0,
                name = "Stephen Cousins"
            };
            var student2 = new ClassPartOfList
            {
                id = 1,
                name = "Austin A. Newton"
            };
            var student3 = new ClassPartOfList
            {
                id = 2,
                name = "Adam Wilhite"
            };
            var student4 = new ClassPartOfList
            {
                id = 3,
                name = "Enis Kurtay YILMAZ"
            };

            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            university.partOfList = listStudent;
        }


    }
}
