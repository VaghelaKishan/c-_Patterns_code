using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class factorialFindUsingRecursion
    {
        int num = 5;
        int result = 1;

        int Factorial()
        {
            if (num == 0)
            {
                return 1;
            }
            result = result * num;
            num--;
            Factorial();
            return result;
        }
        public static void fac1()
        {
            factorialFindUsingRecursion obj = new factorialFindUsingRecursion();
            int factorial = obj.Factorial();
            Console.WriteLine(factorial);
            //Console.ReadLine();
        }
    }
}
