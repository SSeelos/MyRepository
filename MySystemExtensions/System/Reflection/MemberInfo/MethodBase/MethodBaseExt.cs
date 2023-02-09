using System.Reflection;

namespace MySystemExtensions;

public static class MethodBaseExt
{
    public static string Display(this MethodBase method)
        => $"{method.DeclaringType.Display()}.{method.Name}";
}
