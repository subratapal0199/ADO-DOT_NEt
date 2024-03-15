using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ADO_Dot_Net_Exam_04
{
    internal class Class_delete_emp
    {
        public static void delete_emp(string connString)
        {
            Console.Write("Enter the Employee ID which you want to delete: ");
            int emp_id = Convert.ToInt32(Console.ReadLine());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmmd = new SqlCommand("usp_deleteEmployee", conn);
                    cmmd.CommandType = CommandType.StoredProcedure;

                    cmmd.Parameters.AddWithValue("@emp_id", emp_id);

                    cmmd.Parameters.Add("@message", SqlDbType.VarChar, 500);
                    cmmd.Parameters["@message"].Direction = ParameterDirection.Output;

                    conn.Open();
                    cmmd.ExecuteNonQuery();

                    Console.WriteLine(cmmd.Parameters["@message"].Value);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
