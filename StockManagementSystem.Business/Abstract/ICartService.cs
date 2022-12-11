using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.Abstract
{
    public interface ICartService
    {
        List<Cart> GetAll();
        void Add(Cart cart);
        void Delete(Cart cart);
        string Calculate();
    }
}
