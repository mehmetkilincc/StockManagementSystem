using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Business.Utilities;
using StockManagementSystem.Business.ValidationRules.FluentValidation;
using StockManagementSystem.DataAccess.Abstract;

namespace StockManagementSystem.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public List<Admin> GetByAdminId(int id)
        {
            return _adminDal.GetByAdminId(id);
        }

        public void Add(Admin admin)
        {
            var isExsist = _adminDal.GetAll().Where(x => x.UserName == admin.UserName).Count();

            if (isExsist <= 0)
            {
                ValidationTool.Validate(new AdminValidator(), admin);
                _adminDal.Add(admin);
            }
            else
                throw new Exception("This username already exists");
        }

        public void Update(Admin admin)
        {
            ValidationTool.Validate(new AdminValidator(), admin);
            _adminDal.Update(admin);
        }

        public void Delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public bool Login(Admin admin)
        {
            var isExist = _adminDal.GetAll().Where(p => p.UserName == admin.UserName && p.Password == admin.Password && p.IsActive == admin.IsActive).Count();

            if (isExist > 0)
                return true;

            return false;
        }
    }
}
