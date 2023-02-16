using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class array
    {
        public static void vehicle()
        {
            string[] cars = { "volvo", "BMW", "audi", "tata" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            cars[2] = "Lambo";
            Console.WriteLine(cars[2]);

            //loop in array
            string[] car = { "volvo", "BMW", "audi", "tata", "bugati" };
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            // 2D array
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(num[0, 2]);
        }
    }
}
