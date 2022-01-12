using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero magician = new Hero(new Magician());
            magician.Hit();
            magician.Run();

            Hero archer = new Hero(new Archer());
            archer.Hit();
            archer.Run();

            Console.ReadLine();
        }
    }
}
