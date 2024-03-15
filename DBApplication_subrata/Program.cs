using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBApplication_subrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection("server=localhost;database=BikeStores;integrated security=SSPI");
                SqlCommand command = new SqlCommand("select [customer_id],[first_name],[last_name] from [sales].[customers]", connection);
                connection.Open();

                SqlDataReader cust_reader = command.ExecuteReader();

                while (cust_reader.Read())
                {
                    Console.WriteLine(cust_reader["customer_id"]+" "+cust_reader["first_name"] + " " + cust_reader["last_name"]);
                }


                //to see the state of a connection
                ConnectionState state = connection.State;
                Console.WriteLine(state);


                connection.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadKey();
        }
    }
}
