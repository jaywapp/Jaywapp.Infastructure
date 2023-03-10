namespace Jaywapp.Infrastructure.Filter.Interface
{
    public interface IFilterPropertySelector
    {
        string Name { get; }
        eFilterableTargetProperty Type { get; }
        object Select(object target);
    }
}
