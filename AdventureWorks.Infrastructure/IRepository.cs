
using System.Collections.Generic;

namespace AdventureWorks.Infrastructure.DomainBase
{
    public interface IRepository<TEntity>// where TEntity : EntityBase
    {
        IEnumerable<TEntity> ListAll();
        TEntity GetById(int businessEntityId);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int businessEntityId);
    }
}
