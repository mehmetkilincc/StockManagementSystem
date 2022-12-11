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
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal branlDal)
        {
            _brandDal = branlDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetByCategoryName(string categoryName)
        {
           return _brandDal.GetByCategoryName(categoryName);
        }

        public void Add(Brand brand)
        {
            var isExist = _brandDal.GetAll().Where(item=>item.BrandName==brand.BrandName).Count();

            if (isExist <= 0)
            {
                ValidationTool.Validate(new BrandValidator(), brand);
                _brandDal.Add(brand);
            }
            else
                throw new Exception("This brand already exists");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
    }
}
