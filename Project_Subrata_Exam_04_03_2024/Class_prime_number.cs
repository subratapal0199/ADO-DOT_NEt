using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Subrata_Exam_04_03_2024
{
    internal class Class_prime_number
    {
        public static void prime_number()
        {
            
            //take the input from the user
            Console.Write("Enter the number for checking prime: ");
            int num=Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0 && num != 1)
            {
                Console.WriteLine(num + " is prime number.");
            }
            else
            {
                Console.WriteLine(num + " is not prime number");
            }

        }
    }
}
