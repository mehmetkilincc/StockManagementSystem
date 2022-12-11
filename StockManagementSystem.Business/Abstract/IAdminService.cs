using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetAll();
        List<Admin> GetByAdminId(int id);
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
        bool Login(Admin admin);
    }
}
