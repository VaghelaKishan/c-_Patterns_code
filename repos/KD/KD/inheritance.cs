using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class Car
    {
        public string model;
        public int price;
        public string color;

        public void Printcarinfo()
        {
            Console.WriteLine("model: " + model);
            Console.WriteLine("price: " + price);
            Console.WriteLine("color: " + color);
        }
    }

    class Maruti : Car
    {
        float mileage;
        void PrintMileage()
        {
            Console.WriteLine("mileagw: " + mileage);
        }
        public static void in1()
        {
            Maruti mycar = new Maruti();
            mycar.model = "alto";
            mycar.color = "red";
            mycar.price = 100;
            mycar.mileage = 22.5f;
            mycar.Printcarinfo();
            mycar.PrintMileage();
        }
    }
}
