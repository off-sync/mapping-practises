namespace OffSync.Mapping.Practises
{
    public interface IMapper<in TSource, out TTarget>
    {
        TTarget Map(TSource source);
    }
}
