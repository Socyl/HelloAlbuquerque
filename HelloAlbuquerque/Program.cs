using System;

namespace HelloAlbuquerque
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name}");

            Console.WriteLine("Press a key");
            int c = Console.Read();
            Console.WriteLine($"You entered a {c}");
           
        }
    }
}
