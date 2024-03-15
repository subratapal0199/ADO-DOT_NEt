using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ADO_Dot_Net_Exam_04
{
    internal class Class_get_emp
    {
        public static void get_employee(string connString)
        {

            int? emp_id = null;
            Console.Write("Do you want to see the record with specific ID.Then press Y/y: ");
            char ch = Console.ReadLine()[0];
            if (ch == 'y' || ch == 'Y')
            {
                Console.Write("Enter the Employee id: ");
                emp_id=Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                emp_id=null;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmmd = new SqlCommand("usp_getEmployee", conn);
                    cmmd.CommandType = CommandType.StoredProcedure;

                    cmmd.Parameters.AddWithValue("@emp_id", emp_id);
                    cmmd.Parameters.Add("@message", SqlDbType.VarChar, 500);
                    cmmd.Parameters["@message"].Direction = ParameterDirection.Output;

                    conn.Open();
                    SqlDataReader reader = cmmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["emp_id"] + " , " + reader["emp_name"] + " , " + reader["salary"]);
                    }
                    reader.Close();
                    Console.WriteLine(cmmd.Parameters["@message"].Value);
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }

        }
    }
}
