using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DataAccess.Abstract
{
    public interface IAdminDal : IEntityRepository<Admin>
    {
        List<Admin> GetByAdminId(int id);
    }
}
