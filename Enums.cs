using Jaywapp.Infrastructure.Filter.Attribute;
using System.ComponentModel;

namespace Jaywapp.Infrastructure
{
    public enum eLogicalOperator
    {
        AND,
        OR,
    }

    public enum eFilteringOperator
    {
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("=")]
        Equal,
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("≠")]
        NotEqual,
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [Description("＜")]
        LessThan,
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [Description("≤")]
        LessEqual,
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [Description("＞")]
        GreaterThan,
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [Description("≥")]
        GreaterEqual,
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("정규식")]
        MatchRegex,
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("포함")]
        Contains,
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("미포함")]
        NotContains,
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("시작 문자열")]
        StartsWith,
        [FilterableTargetField(eFilterableTargetProperty.String)]
        [FilterableTargetField(eFilterableTargetProperty.Number)]
        [FilterableTargetField(eFilterableTargetProperty.Enum)]
        [Description("끝 문자열")]
        EndsWith,
    }

    public enum eFilterableTargetProperty
    {
        String,
        Enum,
        Number,
    }
}
