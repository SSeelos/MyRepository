using System.Collections.Generic;

namespace MyLibrary.MyDesignPrinciples.BuilderPattern
{
    public class MyPartProduct:IProduct
    {
        private readonly List<object> parts = new List<object>();
        public MyPartProduct(string initPart)
        {
            parts.Add(initPart);
        }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public string OutputParts()
        {
            var str = string.Empty;

            for (var i = 0; i < parts.Count; i++) str += parts[i] + ", ";

            str = str.Remove(str.Length - 2); // removing last ", "

            return "SubProduct parts: " + str + "\n";
        }

    }
}
