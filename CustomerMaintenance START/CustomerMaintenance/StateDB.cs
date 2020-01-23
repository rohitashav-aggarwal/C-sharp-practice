using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data; // for command behaviour
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class StateDB
    {
        public static List<State> GetStates()
        {
            List<State> states = new List<State>();
            State st; // auxiliary 
            // create connection
            using (SqlConnection connection = MMABooksdb.GetConnection())
            {
                // create command
                string query = "select StateCode, StateName from states " +
                                "ORDER BY StateName";
                using (SqlCommand cmd = new SqlCommand(query, connection)) {
                    // run the command and process results
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {

                        while (reader.Read())
                        {
                            // process next record from data reader
                            st = new State();
                            st.StateCode = reader["StateCode"].ToString();
                            st.StateName = reader["StateName"].ToString();
                            states.Add(st);
                        }
                    }// closes reader and recycles object
                }// cmd object recycled
            }// connection object recycled
            return states;
        }
    }
}
