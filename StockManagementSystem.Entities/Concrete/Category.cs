using StockManagementSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Entities.Concrete
{
    public class Category : IEntity
    {
        public string CategoryName { get; set; }
    }
}
