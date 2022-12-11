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
    public class CategoryDal : ICategoryDal
    {
        SqlConnection connection = Connect.GetConnect();
        public List<Category> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * from Categories", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                categories.Add(new Category()
                {
                    CategoryName = reader["CategoryName"].ToString()
                });
            }
            connection.Close();
            return categories;
        }
        public void Add(Category category)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command =
                new SqlCommand("Insert into Categories (CategoryName) values (@CategoryName)", connection);
            command.Parameters.AddWithValue("@CategoryName", category.CategoryName);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
        public void Delete(Category category)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Delete From Categories Where CategoryName = '" + category.CategoryName + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
