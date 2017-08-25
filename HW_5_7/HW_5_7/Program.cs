using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double n;

            Console.WriteLine("Hallo! This programm will calculates sum from 1 to N. Please enter the N:  ");
            n = double.Parse(Console.ReadLine());


            while (a <= n) 
            {
                
                Console.WriteLine(a++);
                
            }

            Console.ReadLine();
        }
    }
}
