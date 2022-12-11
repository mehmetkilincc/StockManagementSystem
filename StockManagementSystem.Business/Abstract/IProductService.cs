using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByProductId(int id);
        Product getProduct(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        void ReduceProductAmount(Product product);
    }
}
