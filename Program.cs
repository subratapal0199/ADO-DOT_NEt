using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_ADO_Dot_Net_Exam_04
{
    internal class Main_Program
    {
        static void Main(string[] args)
        {
            //connection String 
            string connString1 = ConfigurationManager.ConnectionStrings["dbcon1"].ConnectionString;


            //Class_insert_emp emp = new Class_insert_emp();
            //emp.insert_emp(connString1);

            //Class_delete_emp.delete_emp(connString1);

            Class_updateEmp.update_employee(connString1);

            //Class_get_emp.get_employee(connString1);




            Console.ReadKey();
        }
    }
}
