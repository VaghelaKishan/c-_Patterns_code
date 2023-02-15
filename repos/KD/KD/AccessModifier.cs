using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class AccessModifier
    {
        public static void vehicle()
        {
            Car mycar = new Car();
            mycar.model = "ferrari";
            mycar.price = 30000000;
            mycar.color = "black";
            mycar.Printcarinfo();

        }

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
    }
}
