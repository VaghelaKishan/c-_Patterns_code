using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    interface IAnimal
    {
        void animalSound();
    }
    class pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("pig says : wee wee");
        }
    }
    class Program2
    {
        public static void interface1()
        {
            pig mypig = new pig();
            mypig.animalSound();
        }
    }
}
