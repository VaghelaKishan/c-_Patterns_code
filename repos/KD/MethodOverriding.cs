using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class MethodOverriding
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog : MethodOverriding
    {
        public void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
        public static void over()
        {
            Dog tommy = new Dog();
            tommy.Eat();
        }
    }
}
