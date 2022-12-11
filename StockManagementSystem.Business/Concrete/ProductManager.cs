using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.Utilities;
using StockManagementSystem.Business.ValidationRules.FluentValidation;
using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.DataAccess.Concrete;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByProductId(int id)
        {
            return _productDal.GetByProductId(id);
        }

        public Product getProduct(int id)
        {
            return _productDal.GetProduct(id);
        }

        public void Add(Product product)
        {
            var isExsist = _productDal.GetAll().Where(x => x.ProductName == product.ProductName).Count();

            if (isExsist <= 0)
            {
                ValidationTool.Validate(new ProductValidator(), product);
                _productDal.Add(product);
            }
            else
                throw new Exception("This product already exists");
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void ReduceProductAmount(Product product)
        {
            _productDal.ReduceProductAmount(product);
        }
    }
}
