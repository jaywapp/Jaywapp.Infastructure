using Jaywapp.Infrastructure.Filter.Interface;
using System;

namespace Jaywapp.Infrastructure.Filter.Model
{
    public abstract class FilterBase : IFilter
    {
        #region Properties
        /// <inheritdoc/>
        public Type Type => GetType();

        /// <inheritdoc/>
        public eLogicalOperator Logical { get; set; }

        /// <summary>
        /// 필터 이름
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 필터 연산자
        /// </summary>
        public eFilteringOperator Operator { get; set; }
        /// <summary>
        /// 기대값
        /// </summary>
        public string Expect { get; set; }
        #endregion

        #region Functions
        /// <inheritdoc/>
        public bool IsFiltered(object target) => Check(GetActual(target), Expect, Operator);

        /// <summary>
        /// <paramref name="target"/>에서 필터링에 필요한 값을 추출합니다.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        protected abstract object GetActual(object target);

        /// <summary>
        /// <paramref name="actual"/>(실제값)과 <paramref name="expect"/>)기대값이 <paramref name="op"/>(연산자)에 대해 일치하는지 확인합니다.
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="expect"></param>
        /// <param name="op"></param>
        /// <returns></returns>
        protected abstract bool Check(object actual, object expect, eFilteringOperator op);
        #endregion
    }
}
