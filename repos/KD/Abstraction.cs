using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class Abstraction
    {


        abstract class Animal
        {
            public abstract void animalSound();
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }
        class pig : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("The Pig Says: wee wee");
            }
        }



        public static void dog()
        {
            pig mypig = new pig();
            mypig.animalSound();
            mypig.sleep();
        }
    }
}
