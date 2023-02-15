using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class Classobject
    {
        class cars
        {
            public string color = "red";

        }

        public static void obj()
        {
            cars myobj = new cars();
            Console.WriteLine(myobj.color);

        }
    }
}
