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
    public class ProductDal:IProductDal
    {
        SqlConnection connection = Connect.GetConnect();
        public List<Product> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                products.Add(new Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    CategoryName = reader["CategoryName"].ToString(),
                    BrandName = reader["BrandName"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                    SalePrice = Convert.ToDecimal(reader["SalePrice"]),
                    Date = Convert.ToDateTime(reader["Date"])
                });
            }
            connection.Close();
            return products;
        }
        public List<Product> GetByProductId(int id)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Products Where ProductId Like '" + id + "%'", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                products.Add(new Product()
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    CategoryName = reader["CategoryName"].ToString(),
                    BrandName = reader["BrandName"].ToString(),
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                    SalePrice = Convert.ToDecimal(reader["SalePrice"]),
                    Date = Convert.ToDateTime(reader["Date"])
                });
            }
            connection.Close();
            return products;
        }
        public Product GetProduct(int id)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Products Where ProductId ='" + id + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            Product product = new Product();
            if (reader.Read())
            {

                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.ProductName = reader["ProductName"].ToString();
                product.CategoryName = reader["CategoryName"].ToString();
                product.BrandName = reader["BrandName"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]);
                product.SalePrice = Convert.ToDecimal(reader["SalePrice"]);
                product.Date = Convert.ToDateTime(reader["Date"]);
                connection.Close();
                return product;
            }

            connection.Close();
            return product;
        }
        public void Add(Product product)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command =
                new SqlCommand("Insert into Products (ProductName,CategoryName,BrandName,Quantity,PurchasePrice,SalePrice,Date) values (@ProductName,@CategoryName,@BrandName,@Quantity,@PurchasePrice,@SalePrice,@Date)", connection);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@CategoryName", product.CategoryName);
            command.Parameters.AddWithValue("@BrandName", product.BrandName);
            command.Parameters.AddWithValue("@Quantity", product.Quantity);
            command.Parameters.AddWithValue("@PurchasePrice", product.PurchasePrice);
            command.Parameters.AddWithValue("@SalePrice", product.SalePrice);
            command.Parameters.AddWithValue("@Date", product.Date);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(Product product)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Update Products set ProductName=@ProductName , Quantity=@Quantity ,PurchasePrice=@PurchasePrice, SalePrice=@SalePrice Where ProductId='" + product.ProductId + "'", connection);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Quantity", product.Quantity);
            command.Parameters.AddWithValue("@PurchasePrice", product.PurchasePrice);
            command.Parameters.AddWithValue("@SalePrice", product.SalePrice);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(Product product)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Delete From Products Where ProductId = '" + product.ProductId + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void ReduceProductAmount(Product product)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            //Satış işlemi sonrasında sepetteki ürünleri stoktan düşmek için kullandığımız SQL komutlarımız.
            SqlCommand command = new SqlCommand("Update Products set Quantity=Quantity - '" + Convert.ToInt32(product.Quantity) + "'" +
                                                " where ProductId= '" + Convert.ToInt32(product.ProductId) + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
