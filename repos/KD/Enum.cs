using System;

namespace KD
{
    enum Level
    {
        Low,  //0
        Medium, //1
        High  //2
    }
    class Program
    {
        public static void enum1()
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            int mynum = (int)Level.Medium;
            Console.WriteLine(mynum);
        }
    }
}