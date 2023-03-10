using Jaywapp.Infrastructure.Filter.Attribute;
using Jaywapp.Infrastructure.Filter.Interface;
using Jaywapp.Infrastructure.Filter.Model;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jaywapp.Infrastructure.Filter.Service
{
    public class FilterBuilder<T>
    {
        public List<IFilter> Filters { get; } = new List<IFilter>();
        public List<PropertyInfo> Properties { get; }
 
        public FilterBuilder()
        {
            Properties = typeof(T)
                .GetProperties()
                .Where(p => p.TryGetFilterableTargetProperty(out _))
                .ToList();
        }

        public FilterGroup Build()
        {
            return new FilterGroup()
            {
                Logical = eLogicalOperator.AND,
                Children = Filters,
            };
        }
    }
}
