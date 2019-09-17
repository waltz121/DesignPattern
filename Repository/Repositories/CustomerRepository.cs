using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        DesignPatternDBEntities dBEntities;
        public CustomerRepository(DesignPatternDBEntities dBEntities)
        {
            this.dBEntities = dBEntities;
        }

        public void Add(Customer newEntity)
        {
            dBEntities.Customers.Add(newEntity);
        }

        public IQueryable<Customer> Find(Expression<Func<Customer, bool>> predicate)
        {
            var customer = dBEntities.Customers.Where(predicate);
            return customer;
        }

        public IQueryable<Customer> FindAll()
        {
            return dBEntities.Customers;
        }

        public Customer FindById(int id)
        {
            var customer = dBEntities.Customers.Where(x => x.CustomerId == id).SingleOrDefault();
            return customer;
        }

        public void Remove(Customer entity)
        {
            dBEntities.Customers.Remove(entity);
        }
    }
}
