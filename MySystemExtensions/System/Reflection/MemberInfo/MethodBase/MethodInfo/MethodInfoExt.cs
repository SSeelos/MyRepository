using System.Reflection;
using System.Runtime.CompilerServices;

namespace MySystemExtensions;

public static class MethodInfoExt
{
    /// <summary>
    /// this should ensure the method is indeed anonymous
    /// https://stackoverflow.com/questions/12758066/how-to-know-if-an-action-is-an-anonymous-method-or-not</summary>
    /// <param name="methodInfo"></param>
    /// <returns>true if method is anonymous</returns>
    public static bool IsAnonymous(this MethodInfo methodInfo)
    {
        //check the method name for a specific syntax
        if (!RegExExt.AnonymousMethodName.IsMatch(methodInfo.Name))
            return false;

        //same thing?
        //if (methodInfo.IsDefinedByAttribute(typeof(CompilerGeneratedAttribute)))
        if (!methodInfo.DeclaringType.IsDefinedByAttribute<CompilerGeneratedAttribute>())
            return false;

        return true;
    }
    public static string Display(this MethodInfo methodInfo)
    {
        if (methodInfo.IsAnonymous())
            return $"{methodInfo.DeclaringType.DeclaringType.Display()}.{methodInfo.Name}";

        var methodBase = (MethodBase)methodInfo;

        return methodBase.Display();
    }

}
