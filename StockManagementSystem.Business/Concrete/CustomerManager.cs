using StockManagementSystem.Business.Utilities;
using StockManagementSystem.Business.ValidationRules.FluentValidation;
using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Business.Abstract;

namespace StockManagementSystem.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetByCustomerId(int id)
        {
            return _customerDal.GetByCustomerId(id);
        }

        public Customer GetCustomer(int id)
        {
            return _customerDal.GetCustomer(id);
        }

        public void Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }

        public void Update(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }
    }
}

