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
        public void Add(Address newEntity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> Find(Expression<Func<Address, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Address> FindAll()
        {
            throw new NotImplementedException();
        }

        public Address FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
