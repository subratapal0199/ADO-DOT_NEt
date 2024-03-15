using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Customer customer = new Customer();
           // customer.MyID = 101;
            customer.setDetails(101, "Rahul");
            customer.getDetails();
            //Console.Write("Welcome To MCC");
            Console.ReadKey();
        }
    }
    
}
