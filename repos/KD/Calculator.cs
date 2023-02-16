using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class Calculator
    {
        int num1;
        int num2;
        int result;

        void add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }
        void subtract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
        }
        void multiplication()
        {
            result = num1 * num2;
            Console.WriteLine(result);
        }
        void division()
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }

        public static void calc() 
        {
            Calculator obj = new Calculator();
            obj.num1 = 10;
            obj.num2 = 20;
            obj.add();
            obj.subtract();
            obj.multiplication();
            obj.division();


        }
    }
}
