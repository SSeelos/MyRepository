using System.Collections.Generic;

namespace MyLibrary.MyDesignPrinciples.Builder
{
    public interface IProduct
    {
        string OutputParts();
    }
    /// <summary>
    /// Resulting object.
    /// 
    /// Products constructed by different builders 
    /// don’t have to belong to the same class hierarchy or interface
    /// </summary>
    public class MyProduct : IProduct
    {
        private readonly List<object> _parts = new List<object>();

        private readonly List<MyPartProduct> _partProducts = new List<MyPartProduct>();

        public MyProduct(string initPart)
        {
            this._parts.Add(initPart);
        }
        public MyProduct(string initPart, string constr)
        {
            this._parts.Add((initPart, constr));
        }

        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public void AddPartProducts(List<MyPartProduct> parts)
        {
            this._partProducts.AddRange(parts);
        }

        public string OutputParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ", "


            foreach (var part in _partProducts)
            {
                str += "\n\t";
                str += part.OutputParts();
            }


            return "Product parts: " + str + "\n";
        }

    }
}
