using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class Constructor
    {
        public Constructor() // user define constructor , parameterize con..
        {
            Console.WriteLine("hello Constructor");
        }
        
        public static void cons()
        {
            Constructor obj = new Constructor(); // defult constructor
            Console.ReadLine();
            
        }
    }
    
}
