using StockManagementSystem.Business.Abstract;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DataAccess.Abstract;

namespace StockManagementSystem.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        private ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }

        public List<Sale> GetAll()
        {
            return _saleDal.GetAll();
        }

        public void Add(Sale sale)
        {
            _saleDal.Add(sale);
        }
    }
}
