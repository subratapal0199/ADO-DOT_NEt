using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_ADO_Dot_Net_Exam_04
{
    internal class Class_updateEmp
    {
        public static void update_employee(string conString)
        {
            Console.Write("Enter the Employee ID: ");
            int emp_id = Convert.ToInt32(Console.ReadLine());
            string emp_name;
            int salary;
           

            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    SqlCommand cmd = new SqlCommand("usp_updateEmp", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@emp_id", emp_id);

                    int choice;
                    Console.WriteLine("1.Emp_name " + "2.Emp_salary "+"3.Emp_name and salary");
                    Console.Write("Enter your choice which you want to update: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the Employee Name: ");
                            emp_name = Console.ReadLine();
                            cmd.Parameters.AddWithValue("@emp_name", emp_name);
                            break;
                        case 2:
                            Console.Write("Enter the employee salary: ");
                            salary = Convert.ToInt32(Console.ReadLine());
                            cmd.Parameters.AddWithValue("@salary", salary);
                            break;
                        case 3:
                            Console.Write("Enter the Employee Name: ");
                            emp_name = Console.ReadLine();
                            Console.Write("Enter the employee salary: ");
                            salary = Convert.ToInt32(Console.ReadLine());
                            cmd.Parameters.AddWithValue("@emp_name", emp_name);
                            cmd.Parameters.AddWithValue("@salary", salary);
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            break;

                    }
                    cmd.Parameters.Add("@mess", SqlDbType.VarChar, 100);
                    cmd.Parameters["@mess"].Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.Parameters["@mess"].Value);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            


        }
    }
}
