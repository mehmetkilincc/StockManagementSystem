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
    public class CartDal : ICartDal
    {
        SqlConnection connection = Connect.GetConnect();
        public List<Cart> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Carts", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Cart> carts = new List<Cart>();
            while (reader.Read())
            {
                carts.Add(new Cart()
                {
                    CustomerId = Convert.ToInt32(reader["CustomerId"]),
                    CustomerName = reader["CustomerName"].ToString(),
                    CustomerPhone = reader["CustomerPhone"].ToString(),
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    Amount = Convert.ToInt32(reader["Amount"]),
                    SalePrice = Convert.ToDecimal(reader["SalePrice"]),
                    TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                    Date = Convert.ToDateTime(reader["Date"])
                });
            }
            connection.Close();
            return carts;
        }

        public void Add(Cart cart)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Insert Into Carts (CustomerId,CustomerName,CustomerPhone,ProductId,ProductName,Amount,SalePrice,TotalPrice,Date)" +
                                                "values (@CustomerId,@CustomerName,@CustomerPhone,@ProductId,@ProductName,@Amount,@SalePrice,@TotalPrice,@Date)", connection);
            command.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(cart.CustomerId));
            command.Parameters.AddWithValue("@CustomerName", cart.CustomerName);
            command.Parameters.AddWithValue("@CustomerPhone", cart.CustomerPhone);
            command.Parameters.AddWithValue("@ProductId", Convert.ToInt32(cart.ProductId));
            command.Parameters.AddWithValue("@ProductName", cart.ProductName);
            command.Parameters.AddWithValue("@Amount", Convert.ToInt32(cart.Amount));
            command.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(cart.SalePrice));
            command.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(cart.TotalPrice));
            command.Parameters.AddWithValue("@Date", DateTime.Now);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Cart cart)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Update Carts set Amount=Amount+'" + Convert.ToInt32(cart.Amount) + "' Where ProductId='" + cart.ProductId + "'", connection);
            command.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("Update Carts set TotalPrice = Amount * SalePrice where ProductId='"+cart.ProductId + "'", connection);
            command2.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(Cart cart)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Delete From Carts Where ProductId = '" + cart.ProductId + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public string Calculate()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select sum(TotalPrice) from Carts", connection);
            var result = command.ExecuteScalar().ToString();
            connection.Close();
            return result;
        }
    }
}
