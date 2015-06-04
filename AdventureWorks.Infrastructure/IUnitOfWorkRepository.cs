using AdventureWorks.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Infrastructure.RepositoryFramework
{
    public interface IUnitOfWorkRepository
    {
        void PersistNewItem(EntityBase item);
        void PersistUpdatedItem(EntityBase item);
        void PersistDeletedItem(EntityBase item);
    }
}
