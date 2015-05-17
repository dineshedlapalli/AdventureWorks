
namespace AdventureWorks.Infrastructure.DomainBase
{
    public abstract class EntityBase
    {
        private int businessEntityId;
        
        protected EntityBase()
            : this(default(int))
        {
        }
        
        protected EntityBase(int businessEntityId)
        {
            this.businessEntityId = businessEntityId;
        }
        
        public int BusinessEntityId
        {
            get
            {
                return this.businessEntityId;
            }
        }

        #region Equality Tests
        public override bool Equals(object entity)
        {
            if (entity == null || !(entity is EntityBase))
            {
                return false;
            }
            return (this == (EntityBase)entity);
        }

        public static bool operator ==(EntityBase base1, EntityBase base2)
        {
            // check for both null (cast to object or recursive loop)
            if ((object)base1 == null && (object)base2 == null)
            {
                return true;
            }
            // check for either of them == to null
            if ((object)base1 == null || (object)base2 == null)
            {
                return false;
            }
            if (base1.BusinessEntityId != base2.BusinessEntityId)
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(EntityBase base1, EntityBase base2)
        {
            return (!(base1 == base2));
        }

        public override int GetHashCode()
        {
            return this.BusinessEntityId.GetHashCode();
        }
        #endregion

    }
}
