using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit;
            double years;
            double rate = 1.2;
            int i;

            Console.WriteLine(" Enter the summ of GRH which you put in bank:");
            deposit = double.Parse(Console.ReadLine());
           


            Console.WriteLine("Enter the bank deposit age: ");
            years = double.Parse(Console.ReadLine());

         
            
            for ( i = 0; i < years; i++)
            {
                deposit*= rate;
                
            }
            Console.WriteLine("Your deposit after " + years + " years will be : " + deposit);
            Console.ReadLine();
        }
    }
}
