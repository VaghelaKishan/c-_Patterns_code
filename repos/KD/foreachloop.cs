using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class foreachloop
    {
        public static void loop()
        {
            string[] car = { "volvo", "BMW", "audi", "Tata" };
            foreach (string i in car)
            {
                Console.WriteLine(i);
            }
        }
    }
}
