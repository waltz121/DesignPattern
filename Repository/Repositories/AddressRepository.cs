using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class AddressRepository : IRepository<Address>
    {
        DesignPatternDBEntities DBEntities;
        public AddressRepository(DesignPatternDBEntities dBEntities)
        {
            DBEntities = dBEntities;
        }
        public void Add(Address newEntity)
        {
            DBEntities.Addresses.Add(newEntity);
        }

        public IQueryable<Address> Find(Expression<Func<Address, bool>> predicate)
        {
            var address = DBEntities.Addresses.Where(predicate);
            return address;
        }

        public IQueryable<Address> FindAll()
        {
            var address = DBEntities.Addresses;
            return address;
        }

        public Address FindById(int id)
        {
            var address = DBEntities.Addresses.Where(x => x.Id == id).SingleOrDefault();
            return address;
        }

        public void Remove(Address entity)
        {
            DBEntities.Addresses.Remove(entity);
        }
    }
}
