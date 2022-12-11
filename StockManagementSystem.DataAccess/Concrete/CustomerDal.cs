using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.Entities.Concrete;

namespace StockManagementSystem.DataAccess.Concrete
{
    public class CustomerDal : ICustomerDal
    {
        SqlConnection connection = Connect.GetConnect();
        public List<Customer> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Customers", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                customers.Add(new Customer()
                {
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    CustomerName = reader["CustomerName"].ToString(),
                    CustomerPhone = reader["CustomerPhone"].ToString(),
                    CustomerAddress = reader["CustomerAddress"].ToString(),
                    CustomerMail = reader["CustomerMail"].ToString(),
                });
            }
            connection.Close();
            return customers;
        }
        public List<Customer> GetByCustomerId(int id)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Customers Where CustomerId Like '" + id + "%'", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                customers.Add(new Customer()
                {
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    CustomerName = reader["CustomerName"].ToString(),
                    CustomerPhone = reader["CustomerPhone"].ToString(),
                    CustomerAddress = reader["CustomerAddress"].ToString(),
                    CustomerMail = reader["CustomerMail"].ToString()
                });
            }
            connection.Close();
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Customers Where CustomerId ='" + id + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            Customer customer = new Customer();
            if (reader.Read())
            {

                customer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CustomerPhone = reader["CustomerPhone"].ToString();
                customer.CustomerAddress = reader["CustomerAddress"].ToString();
                customer.CustomerMail = reader["CustomerMail"].ToString();
                connection.Close();
                return customer;
            }

            connection.Close();
            return customer;
        }

        public void Add(Customer customer)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command =
                new SqlCommand("Insert into Customers (CustomerName,CustomerPhone,CustomerAddress,CustomerMail) values (@CustomerName,@CustomerPhone,@CustomerAddress,@CustomerMail)", connection);
            command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            command.Parameters.AddWithValue("@CustomerPhone", customer.CustomerPhone);
            command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
            command.Parameters.AddWithValue("@CustomerMail", customer.CustomerMail);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(Customer customer)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Update Customers set CustomerName=@CustomerName , CustomerPhone=@CustomerPhone , CustomerAddress=@CustomerAddress, CustomerMail=@CustomerMail Where CustomerId='" + customer.CustomerId + "'", connection);
            command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
            command.Parameters.AddWithValue("@CustomerPhone", customer.CustomerPhone);
            command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
            command.Parameters.AddWithValue("@CustomerMail", customer.CustomerMail);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(Customer customer)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Delete From Customers Where CustomerId = '" + customer.CustomerId + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
