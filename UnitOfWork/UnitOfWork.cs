using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Repository;
using Repository.Repositories;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOFWork
    {
        DesignPatternDBEntities DBEntities;
        public UnitOfWork(DesignPatternDBEntities DBEntities)
        {
            this.DBEntities = DBEntities;
            CustomerRepo = new CustomerRepository(DBEntities);
            AddressRepo = new AddressRepository(DBEntities);
        }
        public IRepository<Customer> CustomerRepo { get; }

        public IRepository<Address> AddressRepo { get; }

        public void Commit()
        {
            DBEntities.SaveChanges();
        }
    }
}
