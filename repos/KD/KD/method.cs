using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class method
    {
        static void MyMethod()
        {
            Console.WriteLine("Welcome to Droisys");
        }

        static void Method(string fname)
        {
            Console.WriteLine(fname + " name is");
        }
        public static void method1()
        {
            MyMethod();
            MyMethod();
            Method("vaghela");
            Method("Kishan");
        }
    }
}
