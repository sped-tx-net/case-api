using Ims.Case.Entities;

namespace Ims.Case
{
    public interface IUriGenerator
    {
        string Generate<TEntity>(TEntity entity) where TEntity : ICFEntityType;
    }
}