using AdventureWorks.Data;
using AdventureWorks.Infrastructure.DomainBase;
using AdventureWorks.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorks.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> ListAll()
        {
            using(var awEntities = new AdventureWorksEntities())
            {
                return awEntities.People.ToList<Person>();
            }
        }

        public Person GetById(int businessEntityId)
        {
            using (var awEntities = new AdventureWorksEntities())
            {
                return awEntities.People.Where(p => p.BusinessEntityID == businessEntityId).SingleOrDefault();
            }
        }

        public void Insert(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int businessEntityId)
        {
            throw new System.NotImplementedException();
        }
    }
}
