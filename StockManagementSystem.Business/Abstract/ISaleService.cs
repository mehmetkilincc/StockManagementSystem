using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Business.Abstract
{
    public interface ISaleService
    {
        List<Sale> GetAll();
        void Add(Sale sale);
    }
}
