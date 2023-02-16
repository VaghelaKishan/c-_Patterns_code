using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class breakandcontinue
    {
        public static void stop() 
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                    // break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
