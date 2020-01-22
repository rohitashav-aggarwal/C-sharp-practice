using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace sqlconnectionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=password;database=electricitybill;";
            string query = "SELECT * FROM customers";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();


                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        StringBuilder sb = new StringBuilder();
                        
                        string row1 = reader.GetString(0);
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        Console.WriteLine(row1);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

               
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.WriteLine(ex.Message);
            }
            finally {
                // Finally close the connection
                databaseConnection.Close();
            }

            Console.ReadKey();
        }
    }
}
