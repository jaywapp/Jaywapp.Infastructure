using Jaywapp.Infrastructure.Filter.Item;
using Jaywapp.Infrastructure.Filter.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jaywapp.Infrastructure.Filter.Interface
{
    public interface IFilterItem
    {
        Type Type { get; }
    }

    public static class FilterItemExt
    {
        public static IEnumerable<IFilterItem> Convert(this IEnumerable<IFilter> filters)
        {
            foreach (var filter in filters.ToList())
            {
                if (filter is FilterBase filterBase)
                    yield return new FilterItem(filterBase);
                else if (filter is FilterGroup filterGroup)
                    yield return new FilterGroupItem(filterGroup);
            }
        }
    }
}
