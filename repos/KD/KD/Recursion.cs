using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class Recursion
    {
        int num = 1;
        void Counting()
        {
            if (num == 11)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            Counting();
        }
        public static void recur()
        {
            Recursion obj = new Recursion();
            obj.Counting();

        }
    }
}
