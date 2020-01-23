using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CustomerMaintenance
{
    public static class CustomerDB
    {
        // retrieves one customer data
        public static Customer GetCustomer(int custID)
        {
            Customer cust = null;
            using(SqlConnection connection = MMABooksdb.GetConnection())
            {
                string query = "select CustomerId, Name, Address, City, State, ZipCode " +
                                "from customers " +
                                "where CustomerID = @CustomerID"; // query with parameter
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", custID);
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            cust = new Customer();
                            cust.CustomerID = (int)reader["CustomerID"];
                            cust.Name = reader["Name"].ToString();
                            cust.Address = reader["Address"].ToString();
                            cust.City = reader["City"].ToString();
                            cust.State = reader["State"].ToString();
                            cust.ZipCode = reader["ZipCode"].ToString();
                        }
                    }
                }
            }
            return cust;
        } // end getcustomer method

        // inserts record row into customer table and returns generated customer ID
        public static int AddCustomer(Customer cust)
        {
            int customerID = -1;
            using(SqlConnection connection = MMABooksdb.GetConnection())
            {
                string query = "insert into Customers(Name, Address, City, State, ZipCode) " +
                                "output inserted.CustomerID " +
                                "values(@Name, @Address, @City, @State, @ZipCode)";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Name", cust.Name);
                    cmd.Parameters.AddWithValue("@Address", cust.Address);
                    cmd.Parameters.AddWithValue("@City", cust.City);
                    cmd.Parameters.AddWithValue("@State", cust.State);
                    cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);

                    connection.Open();

                    //cmd.ExecuteNonQuery();
                    customerID = (int)cmd.ExecuteScalar(); // 
                    //// retrieve generated customerID
                    //string secondquery = "select ident_current('Customers')";

                    //using(SqlCommand secondcmd = new SqlCommand(secondquery, connection))
                    //{
                    //    connection.Open();
                    //    customerID = Convert.ToInt32(secondcmd.ExecuteScalar());
                    //}
                }
            }
            return customerID;
        }

        // delete a customer
        public static bool DeleteCustomer(Customer cust)
        {
            int count = 0;
            using (SqlConnection connection = MMABooksdb.GetConnection())
            {
                string deletestatement = "delete from customers " +
                                          "where CustomerID = @CustomerID " + // to identify record
                                          "and name = @Name " + // the remaining conditions - for optimistic concurrences
                                          "and address = @Address " +
                                          "and city = @City " +
                                          "and state = @State " +
                                          "and zipcode = @Zipcode";
                using (SqlCommand cmd = new SqlCommand(deletestatement, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", cust.CustomerID);
                    cmd.Parameters.AddWithValue("@Name", cust.Name);
                    cmd.Parameters.AddWithValue("@Address", cust.Address);
                    cmd.Parameters.AddWithValue("@City", cust.City);
                    cmd.Parameters.AddWithValue("@State", cust.State);
                    cmd.Parameters.AddWithValue("@ZipCode", cust.ZipCode);

                    connection.Open();

                    count = cmd.ExecuteNonQuery(); // delete statement

                }
                return (count > 0);
            }
        }// end delete method

        // update customer
        public static bool UpdateCustomer(Customer oldCust, Customer newCust)
        {
            int count; // number of updated rows
            using(SqlConnection connection = MMABooksdb.GetConnection())
            {
                string updatestatement = "update customers set " +
                                         "name = @newName, " +
                                         "Address = @newAddress, " +
                                         "city = @newCity, " +
                                         "state = @newState, " +
                                         "zipcode = @newZipcode " +
                                         "Where customerID = @oldCustomerID " + // to identify record
                                         "and name = @oldName " + // the remaining conditions - for optimistic concurrences
                                         "and Address = @oldAddress " +
                                         "and city = @oldCity " +
                                         "and state = @oldState " +
                                         "and zipcode = @oldZipcode";
                using (SqlCommand cmd = new SqlCommand(updatestatement, connection))
                {
                    cmd.Parameters.AddWithValue("@newCustomerID", newCust.CustomerID);
                    cmd.Parameters.AddWithValue("@newName", newCust.Name);
                    cmd.Parameters.AddWithValue("@newAddress", newCust.Address);
                    cmd.Parameters.AddWithValue("@newCity", newCust.City);
                    cmd.Parameters.AddWithValue("@newState", newCust.State);
                    cmd.Parameters.AddWithValue("@newZipCode", newCust.ZipCode);
                    cmd.Parameters.AddWithValue("@oldCustomerID", oldCust.CustomerID);
                    cmd.Parameters.AddWithValue("@oldName", oldCust.Name);
                    cmd.Parameters.AddWithValue("@oldAddress", oldCust.Address);
                    cmd.Parameters.AddWithValue("@oldCity", oldCust.City);
                    cmd.Parameters.AddWithValue("@oldState", oldCust.State);
                    cmd.Parameters.AddWithValue("@oldZipCode", oldCust.ZipCode);

                    connection.Open();

                    count = cmd.ExecuteNonQuery(); // returns number of rows updated

                }
            }
            return (count > 0);
        }

    }// end class
}// end namespace
