using System;
using System.Linq;
using System.Reflection;

namespace Jaywapp.Infrastructure.Filter.Attribute
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class FilterableTargetFieldAttribute : System.Attribute
    {
        public eFilterableTargetProperty Type { get; }

        public FilterableTargetFieldAttribute(eFilterableTargetProperty type)
        {
            Type = type;
        }
    }

    public static class FilterableTargetFieldExt
    {
        public static bool TryGetFilterableTargetField(this Enum value, out FilterableTargetFieldAttribute attr)
        {
            var field = value.GetType().GetField(value.ToString());
            attr = field.GetCustomAttribute<FilterableTargetFieldAttribute>();
            return attr != null;
        }

        public static bool IsTargetField(this Enum value, eFilterableTargetProperty type)
        {
            var field = value.GetType().GetField(value.ToString());
            var attrs = field.GetCustomAttributes<FilterableTargetFieldAttribute>().ToList();

            foreach(var attr in attrs)
            {
                if (attr.Type == type)
                    return true;
            }

            return false;
        }

    }
}
