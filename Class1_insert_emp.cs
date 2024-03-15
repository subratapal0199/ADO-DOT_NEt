using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ADO_Dot_Net_Exam_04
{
    internal class Class_insert_emp
    {

        public void insert_emp(string connString)
        {
            Console.Write("Enter the Employee ID: ");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Employee Name: ");
            string name=Console.ReadLine();
            Console.Write("Enter the Employee Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("usp_putEmployee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] parameter_list = new SqlParameter[]
                    {
                        new SqlParameter("@emp_id",id),
                        new SqlParameter("@emp_name",name),
                        new SqlParameter("@salary",salary)

                    };

                    cmd.Parameters.AddRange(parameter_list);

                    cmd.Parameters.Add("@message", SqlDbType.VarChar, 100);
                    cmd.Parameters["@message"].Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.Parameters["@message"].Value);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
