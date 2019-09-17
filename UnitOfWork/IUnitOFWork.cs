using DataAccess;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IUnitOFWork
    {
        IRepository<Customer> CustomerRepo { get; }
        IRepository<Address> AddressRepo { get; }
        void Commit();
    }
}
