namespace MySystemExtensions;

public static class TypeExt
{
    public static string Display(this Type type)
    {
        if (type == null)
            return "";

        if (type.BaseType == null || type.BaseType.Equals(typeof(object)))
            return $"{type.Name}";

        return $"{type.Name}:{type.BaseType.Name}";
    }
}
