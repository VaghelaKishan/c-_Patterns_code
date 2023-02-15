using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class whileloop
    {
        public static void while1()
        {
            int i = 0;
            //while (i<=5) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
    }
}
