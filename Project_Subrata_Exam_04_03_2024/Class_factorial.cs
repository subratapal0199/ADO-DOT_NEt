using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Subrata_Exam_04_03_2024
{
    internal class Class_factorial
    {
       public static void factorial()
        {
            Console.Write("Enter the number for calculate factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            if (number < 1)
            {
                Console.WriteLine("The Number is negative and 0");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("The factorial of " + number + " is:" + fact);
            }
        }
    }
}
