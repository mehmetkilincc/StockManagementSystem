using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<Customer> GetByCustomerId(int id);
        Customer GetCustomer(int id);
    }
}
