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
        [Description("=")]
        Equal,
        [Description("≠")]
        NotEqual,
        [Description("＜")]
        LessThan,
        [Description("≤")]
        LessEqual,
        [Description("＞")]
        GreaterThan,
        [Description("≥")]
        GreaterEqual,
        [Description("정규식")]
        MatchRegex,
        [Description("포함")]
        Contains,
        [Description("미포함")]
        NotContains,
        [Description("시작 문자열")]
        StartsWith,
        [Description("끝 문자열")]
        EndsWith,
    }
}
