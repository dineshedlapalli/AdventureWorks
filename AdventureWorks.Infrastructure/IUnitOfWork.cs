
using AdventureWorks.Infrastructure.DomainBase;
using AdventureWorks.Infrastructure.RepositoryFramework;
namespace AdventureWorks.Infrastructure
{
    public interface IUnitOfWork
    {
        void RegisterAdded(EntityBase entity, IUnitOfWorkRepository repository);
        void RegisterChanged(EntityBase entity, IUnitOfWorkRepository repository);
        void RegisterRemoved(EntityBase entity, IUnitOfWorkRepository repository);
        void Commit();
    }
}
