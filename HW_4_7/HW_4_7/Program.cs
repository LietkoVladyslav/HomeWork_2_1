using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string car_1;
            string car_2;
            string car_3;
            double maxSpeed_1;
            double maxSpeed_2;
            double maxSpeed_3;
            double fuel_1;
            double fuel_2;
            double fuel_3;

            Console.WriteLine("Enter the first car mark:  ");
            car_1 = Console.ReadLine();

            Console.WriteLine("Enter the second car mark:  ");
            car_2 = Console.ReadLine();

            Console.WriteLine("Enter the third car mark:  ");
            car_3 = Console.ReadLine();

            Console.WriteLine("Enter the max speed of first car:  ");
            maxSpeed_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the max speed of second car:  ");
            maxSpeed_2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the max speed of third car:  ");
            maxSpeed_3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fuel consumption of first car:  ");
            fuel_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fuel consumption of second car:  ");
            fuel_2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fuel consumption of third car:  ");
            fuel_3 = double.Parse(Console.ReadLine());

            if (maxSpeed_1 > maxSpeed_2 && maxSpeed_1 > maxSpeed_3 && maxSpeed_2 > maxSpeed_3)
                
            {
                Console.WriteLine(car_1 +"\t"+ maxSpeed_1 + " km/h" + "\t" + car_2 + "\t" + maxSpeed_2 +" km/h" + "\t" + car_3 + "\t" + maxSpeed_3 + " km/h");
            }

            if (maxSpeed_1 > maxSpeed_2 && maxSpeed_1 > maxSpeed_3 && maxSpeed_3 > maxSpeed_2)
            {
                Console.WriteLine(car_1 + "\t" + maxSpeed_1 + " km/h" + "\t" + car_3 + "\t" + maxSpeed_3 + " km/h" + "\t" + car_2 + "\t" + maxSpeed_2 + " km/h");
            }

            if (maxSpeed_2 > maxSpeed_1 && maxSpeed_2 > maxSpeed_3 && maxSpeed_1 > maxSpeed_3)
            {
                Console.WriteLine(car_2 + "\t" + maxSpeed_2 + " km/h" + "\t" + car_1 + "\t" + maxSpeed_1 + " km/h" + "\t" + car_3 + "\t" + maxSpeed_3 + " km/h");
            }

            if (maxSpeed_2 > maxSpeed_1 && maxSpeed_2 > maxSpeed_3 && maxSpeed_3 > maxSpeed_1)
            {
                Console.WriteLine(car_2 + "\t" + maxSpeed_2 + " km/h" + "\t" + car_3 + "\t" + maxSpeed_3 + " km/h" + "\t" + car_1 + "\t" + maxSpeed_1 + " km/h");
            }

            if (maxSpeed_3 > maxSpeed_1 && maxSpeed_3 > maxSpeed_2 && maxSpeed_1 > maxSpeed_2)
            {
                Console.WriteLine(car_3 + "\t" + maxSpeed_3 + " km/h" + "\t" + car_1 + "\t" + maxSpeed_1 + " km/h" + "\t" + car_2 + "\t" + maxSpeed_2 + " km/h");
            }

            if (maxSpeed_3 > maxSpeed_1 && maxSpeed_3 > maxSpeed_2 && maxSpeed_2 > maxSpeed_1)
            {
                Console.WriteLine(car_3 + "\t" + maxSpeed_3 + " km/h" + "\t" + car_2 + "\t" + maxSpeed_2 + " km/h" + "\t" + car_1 + "\t" + maxSpeed_1 + " km/h");
            }

                if (fuel_1 > fuel_2 && fuel_1 > fuel_3 && fuel_2 > fuel_3)

            {
                Console.WriteLine(car_1 + "\t" + fuel_1 + " l/100km" + "\t" + car_2 + "\t" + fuel_2 + " l/100km" + "\t" + car_3 + "\t" + fuel_3 + " l/100km");
            }

            if (fuel_1 > fuel_2 && fuel_1 > fuel_3 && fuel_3 > fuel_2)
            {
                Console.WriteLine(car_1 + "\t" + fuel_1 + " l/100km" + "\t" + car_3 + "\t" + fuel_3 + " l/100km" + "\t" + car_2 + "\t" + fuel_2 + " l/100km");
            }

            if (fuel_2 > fuel_1 && fuel_2 > fuel_3 && fuel_1 > fuel_3)
            {
                Console.WriteLine(car_2 + "\t" + fuel_2 + " l/100km" + "\t" + car_1 + "\t" + fuel_1 + " l/100km" + "\t" + car_3 + "\t" + fuel_3 + " l/100km");
            }

            if (fuel_2 > fuel_1 && fuel_2 > fuel_3 && fuel_3 > fuel_1)
            {
                Console.WriteLine(car_2 + "\t" + fuel_2 + " l/100km" + "\t" + car_3 + "\t" + fuel_3 + " l/100km" + "\t" + car_1 + "\t" + fuel_1 + " l/100km");
            }

            if (fuel_3 > fuel_1 && fuel_3 > fuel_2 && fuel_1 > fuel_2)
            {
                Console.WriteLine(car_3 + "\t" + fuel_3 + " l/100km" + "\t" + car_1 + "\t" + fuel_1 + " l/100km" + "\t" + car_2 + "\t" + fuel_2 + " l/100km");
            }

            if (fuel_3 > fuel_1 && fuel_3 > fuel_2 && fuel_2 > fuel_1)
            {
                Console.WriteLine(car_3 + "\t" + fuel_3 + "l/100km" + "\t" + car_2 + "\t" + fuel_2 + "l/100km" + "\t" + car_1 + "\t" + fuel_1 + "l/100km");
            }



            Console.ReadLine();
        }
    }
}
