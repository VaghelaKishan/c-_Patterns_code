using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class multipleObject
    {
        class car
        {
            public string color = "blue";

            
        }
        public static void multiobj()
        {
            car myobj1 = new car();
            car myobj2 = new car();
            Console.WriteLine(myobj1.color);
            Console.WriteLine(myobj2.color);
        }
    }
}
