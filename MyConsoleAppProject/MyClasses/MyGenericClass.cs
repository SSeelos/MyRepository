using System.Reflection;

namespace MyConsoleAppProject
{
    public class MyGenericClass
    {

        public T[] CreateArray<T>(T first, T second)
        {
            return new T[] { first, second };
        }

        public T GetNewT<T>() where T : class, new()
        {
            return new T();
        }
        public PropertyInfo[] GetPropertiesOfT<T>() where T : class, new()
        {
            T type = new T();
            PropertyInfo[] props = type.GetType().GetProperties();

            return props;
        }
    }
    public class MyGenericClassT<T>
    {
        T type;
        public T GetGenericType() => type;
    }
}
