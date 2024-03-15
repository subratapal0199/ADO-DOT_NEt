using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Subrata_Exam_04_03_2024
{
    internal class Class_pattern
    {
        public void pattern()
        {
            int num = 5;

            for(int i = 0; i <=num; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            for (int i = num-1; i >=0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
