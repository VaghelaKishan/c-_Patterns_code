using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class Overloading
    {
        void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        void sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public static void overload()
        {
            Overloading obj = new Overloading();
            obj.sum(10, 20);
            obj.sum(10, 20.5f);

        }
    }
}
