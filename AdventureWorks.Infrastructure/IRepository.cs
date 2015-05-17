
namespace AdventureWorks.Infrastructure.DomainBase
{
    public interface IRepository<T> where T : EntityBase
    {
        T FindBy(int businessEntityId);
        void Add(T item);
        T this[int businessEntityId] { get; set; }
        void Remove(T item);
    }
}
