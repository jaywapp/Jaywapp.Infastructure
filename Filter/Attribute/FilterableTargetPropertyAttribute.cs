using System;
using System.Reflection;

namespace Jaywapp.Infrastructure.Filter.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FilterableTargetPropertyAttribute : System.Attribute
    {
        public string Name { get; }
        public eFilterableTargetProperty Type { get; }

        public FilterableTargetPropertyAttribute(string name, eFilterableTargetProperty type)
        {
            Name = name;
            Type = type;
        }
    }

    public static class FilterableTargetPropertyExt
    {
        public static bool TryGetFilterableTargetProperty(this PropertyInfo property, out FilterableTargetPropertyAttribute attr)
        {
            attr = property.GetCustomAttribute<FilterableTargetPropertyAttribute>();
            return attr != null;
        }

        public static string GetTargetName(this PropertyInfo property)
        {
            return TryGetFilterableTargetProperty(property, out FilterableTargetPropertyAttribute attr)
                ? attr.Name : string.Empty;
        }
    }
}
