using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Subrata_Exam_04_03_2024
{
    internal class Main_program
    {
        static void Main(string[] args)
        {
            //1.Write a console app using C# to print your name vertically.

            //Class_Vertically_String_print class_ob = new Class_Vertically_String_print();
            //Console.WriteLine("The string be like: ");
            //class_ob.method_string_print();

            // 2.Write a console app using C# to take input a number and show if it is a prime number or   not?                                                                                                                                                           
            //Class_prime_number.prime_number();

            //3.Write a program in console app using C# to take a number as input and calculate its factorial and display as output?                                                                                                                          
            //Class_factorial.factorial();

            Class_pattern class_Pattern = new Class_pattern();
            class_Pattern.pattern();


            Console.ReadKey();
        }
    }
}
