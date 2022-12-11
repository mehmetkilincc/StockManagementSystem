using StockManagementSystem.DataAccess.Abstract;
using StockManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DataAccess.Concrete
{
    public class AdminDal : IAdminDal
    {
        private SqlConnection connection = Connect.GetConnect();
        public List<Admin> GetAll()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Admins", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Admin> admins = new List<Admin>();
            while (reader.Read())
            {
                admins.Add(new Admin()
                {
                    AdminId = Convert.ToInt32(reader["AdminId"]),
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"])
                });
            }
            connection.Close();
            return admins;
        }
        public List<Admin> GetByAdminId(int id)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Select * From Admins Where AdminId Like '" + id + "%'", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Admin> admins = new List<Admin>();
            while (reader.Read())
            {
                admins.Add(new Admin()
                {
                    AdminId = Convert.ToInt32(reader["AdminId"]),
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"])
                });
            }
            connection.Close();
            return admins;
        }
        public void Add(Admin admin)
        {
            //  CheckAdmin(admin);
            //if (adminState == true)
            //{
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Insert into Admins (UserName,Password) values (@UserName,@Password)", connection);
            command.Parameters.AddWithValue("@UserName", admin.UserName);
            command.Parameters.AddWithValue("@Password", admin.Password);
            command.ExecuteNonQuery();
            connection.Close();
            //}
        }
        public void Update(Admin admin)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Update Admins set UserName=@UserName , Password=@Password , IsActive=@IsActive Where AdminId='" + admin.AdminId + "'", connection);
            command.Parameters.AddWithValue("@UserName", admin.UserName);
            command.Parameters.AddWithValue("@Password", admin.Password);
            if (admin.IsActive)
            {
                command.Parameters.AddWithValue("@IsActive", 1);
            }
            if (!admin.IsActive)
            {
                command.Parameters.AddWithValue("@IsActive", 0);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(Admin admin)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Delete From Admins Where AdminId = '" + admin.AdminId + "'", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
