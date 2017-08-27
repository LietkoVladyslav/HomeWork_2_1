using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = 1;
            int b = 50;

            for (int i = a; i <= b; i++)
            {

                Console.Write(i + " ");

                if (i % 3 == 0 || i % 5 > 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
