using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4;
            double b = 5;
            double y = (a / b);
            double z = 20;
            double x = (z / y);

            Console.WriteLine("Solve equation: 4/5 * x - 20 = 0 ");
            Console.WriteLine("x =  " + x );

            Console.ReadLine();
        }
    }
}
