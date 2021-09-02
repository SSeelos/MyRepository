namespace MyLibrary.MyJSON
{
    public class Student
    {
        public string name { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return string.Format("Info:\n Id: {0}, Name: {1}", id, name);
        }
    }
}
