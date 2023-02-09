using System.Reflection;

namespace MySystemExtensions;

public static class MemberInfoExt
{
    public static bool IsDefinedByAttribute<T>(this MemberInfo memberInfo)
        where T : Attribute
        => Attribute.IsDefined(memberInfo, typeof(T));
    public static bool IsDefinedByAttribute(this MemberInfo memberInfo, Type attributeType)
        => Attribute.IsDefined(memberInfo, attributeType);
}
