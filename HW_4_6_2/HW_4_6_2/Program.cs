﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNum_1;
            double inputNum_2;
            int action;
            Console.WriteLine("This programm can calculate two numbers, enter the first number: ");
            inputNum_1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Enter the second number: ");
            inputNum_2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Select action for addicion press 1, for substraction press 2, for multuply press 3, for division press 4, for remainder of the division press 5:  ");
            action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    {
                Console.WriteLine(" The sum is: " + (inputNum_1 + inputNum_2));
                        break;
                    }

                case 2:
                    {
                Console.WriteLine(" The sum is: " + (inputNum_1 - inputNum_2));
                        break;
                    }

                case 3:
                    {
                Console.WriteLine(" The sum is: " + (inputNum_1 * inputNum_2));
                        break;
                    }

                case 4:
                    {
                Console.WriteLine(" The sum is: " + (inputNum_1 / inputNum_2));
                        break;
                    }

                case 5:
                    {
                Console.WriteLine(" The sum is: " + (inputNum_1 % inputNum_2));
                        break;
                    }

                default:
                    {
                Console.WriteLine(" Please enter the correct number of action!");
                        break;
                    }
             }

            Console.ReadLine();

        }
    }
}
