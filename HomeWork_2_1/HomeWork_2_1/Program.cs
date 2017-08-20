using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double numInput_1;
            double numInput_2;
           
            Console.Write(" Hallo, to add two numbers, enter the first number: ");
            numInput_1 = double.Parse(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            numInput_2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Result: " + (numInput_1 + numInput_2));

            Console.Write(" You can subtract from one number another, for this, enter the first number: ");
            numInput_1 = double.Parse(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            numInput_2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Result: " + (numInput_1 - numInput_2));

            Console.Write(" You can multiply one number by another, to do this, enter the first number: ");
            numInput_1 = double.Parse(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            numInput_2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Result: " + (numInput_1 * numInput_2));

            Console.Write(" You can divide one number into another, for this, enter the first number: ");
            numInput_1 = double.Parse(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            numInput_2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Result: " + (numInput_1 / numInput_2));

            Console.Write(" You can calculate the remainder of the division for the number: ");
            numInput_1 = double.Parse(Console.ReadLine());
            Console.Write(" Divide by number: ");
            numInput_2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Result: " + (numInput_1 % numInput_2));

            Console.Write(" Thank you! Game over!");

            Console.ReadLine();
        }
    }
}
