using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Business.Utilities;
using StockManagementSystem.Business.ValidationRules.FluentValidation;
using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.Business.Concrete
{
    public class CartManager:ICartService
    {
        private ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public List<Cart> GetAll()
        {
            return _cartDal.GetAll();
        }

        public void Add(Cart cart)
        {
            var isExsist = _cartDal.GetAll().Where(p => p.ProductId == cart.ProductId).Count();

            if (isExsist > 0)
            {
                ValidationTool.Validate(new CartValidator(), cart);
                _cartDal.Update(cart);
            }
            else
            {
                ValidationTool.Validate(new CartValidator(), cart);
                _cartDal.Add(cart);
            }
            
        }

        public void Delete(Cart cart)
        {
            _cartDal.Delete(cart);
        }

        public string Calculate()
        {
            return _cartDal.Calculate();
        }
    }
}
