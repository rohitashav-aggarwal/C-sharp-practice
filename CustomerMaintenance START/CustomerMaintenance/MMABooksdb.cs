using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class MMABooksdb
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = MMABooks; Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
