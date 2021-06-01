using System;

namespace NameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("what is your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"mayname is {name} and my age is {age}");
        }
    }
}
