using System;
using System.Collections.Generic;
using System.Reflection;

namespace Jaywapp.Infrastructure.Filter.Attribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FilterableTargetClassAttribute : System.Attribute
    {
    }

    public static class FilterableTargetClassAttributeExt
    {
        public static bool IsFilterableTarget<T>(this T target)
            where T : class
        {
            var attr = target.GetType().GetCustomAttribute<FilterableTargetClassAttribute>();
            return attr != null;
        }

        public static bool IsFilterableTargetType(this Type type)
        {
            var attr = type.GetCustomAttribute<FilterableTargetClassAttribute>();
            return attr != null;
        }

        public static IEnumerable<PropertyInfo> GetFilterableProperties(this Type type)
        {
            if (!IsFilterableTargetType(type))
                yield break;

            var properties = type.GetProperties();

            foreach(var property in properties)
            {
                if(property.TryGetFilterableTargetProperty(out FilterableTargetPropertyAttribute attr))
                    yield return property;
            }
        }
    }
}
