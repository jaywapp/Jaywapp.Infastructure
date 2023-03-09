using Jaywapp.Infrastructure.Filter.Interface;
using System;
using System.Collections.Generic;

namespace Jaywapp.Infrastructure.Filter.Model
{
    public class FilterGroup : IFilter
    {
        #region Properties
        /// <inheritdoc/>
        public Type Type => GetType();

        /// <inheritdoc/>
        public eLogicalOperator Logical { get; set; }

        /// <summary>
        /// 하위 필터 목록
        /// </summary>
        public List<IFilter> Children { get; } = new List<IFilter>();
        #endregion

        #region Functions
        /// <inheritdoc/>
        public bool IsFiltered(object obj) => Children.IsFilterd(obj);
        #endregion
    }
}
