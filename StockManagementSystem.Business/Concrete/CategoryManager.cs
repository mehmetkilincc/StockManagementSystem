using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.Business.Utilities;
using StockManagementSystem.Business.ValidationRules.FluentValidation;
using StockManagementSystem.DataAccess.Concrete;

namespace StockManagementSystem.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Add(Category category)
        {
            var isExist = _categoryDal.GetAll().Where(item => item.CategoryName == category.CategoryName).Count();

            if (isExist <= 0)
            {
                ValidationTool.Validate(new CategoryValidator(), category);
                _categoryDal.Add(category);
            }
            else
                throw new Exception("This category already exists");
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
