using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dog obj = new Dog();
            obj.GetName(name);
            obj.Eat();
        }
    }
}
