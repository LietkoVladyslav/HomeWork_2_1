using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double hiPrice = 2.0;
            double lowPrice = 1.0;
            double newPrice;

            Console.WriteLine("Enter new price: ");
            newPrice = double.Parse(Console.ReadLine());
            
            if (newPrice > hiPrice)
            {
                Console.WriteLine("Price has a new hi level ");
            }
            if  (newPrice < lowPrice)
            {
                Console.WriteLine("Price has a new low level ");
            }
            Console.ReadLine();
        }
    }
}
