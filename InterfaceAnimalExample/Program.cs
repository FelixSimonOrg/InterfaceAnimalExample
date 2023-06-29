using System;
using InterfaceAnimalExample;

namespace InterfaceAnimalsExample
{
    internal class Program
    {
        internal static void Main(string[] args)
        {

            //erzeugen von cat & dog instanzen
            Console.WriteLine("Hello, World!");
            Cat cat = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = cat2;

            Dog dog = new Dog();

            Console.WriteLine(cat.Equals(cat2));
            Console.WriteLine(cat.GetHashCode());
            Console.WriteLine(cat2.GetHashCode());
            Console.WriteLine(cat.Equals(dog));
            Console.WriteLine(cat.GetHashCode());
            Console.WriteLine(dog.GetHashCode());


            Console.WriteLine(cat.GetHealth());
            Console.WriteLine(dog.GetHealth());

        }
    }
}

