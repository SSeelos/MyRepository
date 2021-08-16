namespace MyLibrary.MyDesignPrinciples.MyBuilderPattern
{
    public class MyFluentProduct : IProduct
    {
        private string partA;
        private string partB_Optional;
        private string partC;
        public void SetPartA(string part)
        {
            partA = part;
        }
        public void SetPartB_Optional(string part)
        {
            partB_Optional = part;
        }
        public void SetPartC(string part)
        {
            partC = part;
        }
        public string OutputParts()
        {
            string str = string.Empty;
            var seperator = ", ";
            str += partA + seperator;
            if (partB_Optional != null)
                str += partB_Optional + seperator;
            str += partC + seperator;

            str = str.Remove(str.Length - 2); // removing last ", "

            return "FluentProduct parts: " + str + "\n";
        }
    }
}
