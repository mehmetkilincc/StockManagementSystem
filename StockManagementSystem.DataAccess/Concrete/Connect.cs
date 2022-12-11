using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.DataAccess.Concrete
{
    public static class Connect
    {
        private static string ConnectionString = "Data Source=DESKTOP-6C19N8J;Initial Catalog=StockManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection GetConnect()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}