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
    public class BrandDal : IBrandDal
    {
        SqlConnection connection = Connect.GetConnect();
        public List<Brand> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Brands Order By CategoryName Asc", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Brand> brands = new List<Brand>();
            while (reader.Read())
            {
                brands.Add(new Brand()
                {
                    CategoryName = reader["CategoryName"].ToString(),
                    BrandName = reader["BrandName"].ToString()
                });
            }
            connection.Close();
            return brands;
        }

        public List<Brand> GetByCategoryName(string categoryName)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Brands Where CategoryName = '" + categoryName + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Brand> brands = new List<Brand>();
            while (reader.Read())
            {
                brands.Add(new Brand()
                {
                    BrandName = reader["BrandName"].ToString(),
                    CategoryName = reader["CategoryName"].ToString()
                });
            }
            connection.Close();
            return brands;
        }

        public void Add(Brand brand)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command =
                new SqlCommand("Insert into Brands (CategoryName,BrandName) values (@CategoryName,@BrandName)", connection);
            command.Parameters.AddWithValue("@CategoryName", brand.CategoryName);
            command.Parameters.AddWithValue("@BrandName", brand.BrandName);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand brand)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Delete From Brands Where BrandName = '" + brand.BrandName + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
