
using AdventureWorks.Infrastructure.DomainBase;
namespace AdventureWorks.Infrastructure.RepositoryFramework
{
    public abstract class RepositoryBase<T> : IRepository<T>, IUnitOfWorkRepository where T : EntityBase
    {
        private IUnitOfWork unitOfWork;
        protected RepositoryBase()
            : this(null)
        {
        }

        protected RepositoryBase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        #region IRepository < T > Members
        public abstract T FindBy(int businessEntityId);

        public void Add(T item)
        {
            if (this.unitOfWork != null)
            {
                this.unitOfWork.RegisterAdded(item, this);
            }
        }

        public void Remove(T item)
        {
            if (this.unitOfWork != null)
            {
                this.unitOfWork.RegisterRemoved(item, this);
            }
        }

        public T this[int businessEntityId]
        {
            get
            {
                return this.FindBy(businessEntityId);
            }
            set
            {
                if (this.FindBy(businessEntityId) == null)
                {
                    this.Add(value);
                }
                else
                {
                    this.unitOfWork.RegisterChanged(value, this);
                }
            }
        }

        #endregion

        #region IUnitOfWorkRepository Members
        public void PersistNewItem(EntityBase item)
        {
            this.PersistNewItem((T)item);
        }

        public void PersistUpdatedItem(EntityBase item)
        {
            this.PersistUpdatedItem((T)item);
        }

        public void PersistDeletedItem(EntityBase item)
        {
            this.PersistDeletedItem((T)item);
        }
        #endregion

        protected abstract void PersistNewItem(T item);
        protected abstract void PersistUpdatedItem(T item);
        protected abstract void PersistDeletedItem(T item);

        public System.Collections.Generic.IEnumerable<T> ListAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int businessEntityId)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int businessEntityId)
        {
            throw new System.NotImplementedException();
        }
    }
}
