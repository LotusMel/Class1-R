using System;

namespace Class1_R
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            if (name == "Amar")
            {
                Console.WriteLine("Hello, " + name + ". I like your shoes");
            }
            else if (name == "Brandy")
            {
                Console.WriteLine("Hello, " + name + ". You seem like a cool person");
            }
            else if (name == "Emma")
            {
                Console.WriteLine("Hi, Baby Girl!");
            }
            else
            {
                Console.WriteLine("Hello ," + name + ".");
            }

            Console.ReadLine();
        }
    }
}
