using System.Collections.Generic;

namespace MyLibrary.MyJSON
{
    public class ClassToSerialize
    {
        public string name { get; set; }
        public IList<ClassPartOfList> partOfList { get; set; }

    }
}
