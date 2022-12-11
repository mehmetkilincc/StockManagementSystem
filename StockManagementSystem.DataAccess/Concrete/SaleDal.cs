using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DataAccess.Concrete
{
    public class SaleDal : ISaleDal
    { 
        SqlConnection connection = Connect.GetConnect();
        public List<Sale> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Sales Order By Date Desc", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                sales.Add(new Sale()
                {
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    CustomerName = reader["CustomerName"].ToString(),
                    CustomerPhone = reader["CustomerPhone"].ToString(),
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    Amount = Convert.ToInt32(reader["Amount"]),
                    SalePrice = Convert.ToDecimal(reader["SalePrice"]),
                    TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                    Date = DateTime.Parse(reader["Date"].ToString())
                });
            }
            connection.Close();
            return sales;
        }

        public void Add(Sale sale)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Insert Into Sales (CustomerId,CustomerName,CustomerPhone,ProductId,ProductName,Amount,SalePrice,TotalPrice,Date)" +
                "values (@CustomerId,@CustomerName,@CustomerPhone,@ProductId,@ProductName,@Amount,@SalePrice,@TotalPrice,@Date)", connection);
            command.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(sale.CustomerId));
            command.Parameters.AddWithValue("@CustomerName", sale.CustomerName);
            command.Parameters.AddWithValue("@CustomerPhone", sale.CustomerPhone);
            command.Parameters.AddWithValue("@ProductId", Convert.ToInt32(sale.ProductId));
            command.Parameters.AddWithValue("@ProductName", sale.ProductName);
            command.Parameters.AddWithValue("@Amount", Convert.ToInt32(sale.Amount));
            command.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(sale.SalePrice));
            command.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(sale.TotalPrice));
            command.Parameters.AddWithValue("@Date", DateTime.Now);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
