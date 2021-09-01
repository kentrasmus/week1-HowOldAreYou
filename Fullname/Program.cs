using System;

namespace Fullname
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //step 1. programm küsib kasutaja käest kasutaja eesnime
            //step 2. programm küsib kasutaja käest kasutaja perekonnanime
            //step 3. programm tervitab kasutajat kasutades neid andmeid

            Console.WriteLine("Hello, what is your name?");
             string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}");
            Console.WriteLine("what is your last name?");

            string lastname = Console.ReadLine();
            Console.WriteLine($"Hello {lastname}");
            Console.WriteLine("Its nice to meet ya");



        }
    }
}
