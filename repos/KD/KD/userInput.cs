using System;

namespace KD
{
    public class userInput
    {

        public static void input()
        {
            // user input
            Console.WriteLine("Enter Your name: ");

            string username = Console.ReadLine();
            Console.WriteLine("username is :" + username);
        }
    }
}
