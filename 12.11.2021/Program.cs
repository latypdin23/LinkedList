using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //пример 1
            Person edison = new Person("Thomas Edison", 1847);

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + edison.Name);
            Console.WriteLine("Born Year: " + edison.BornYear);
            Console.WriteLine("Place Of Birth: " + edison.PlaceOfBirth);


            Person billGates = new Person("Bill Gates", 1955, "Seattle, Washington");

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + billGates.Name);
            Console.WriteLine("Born Year: " + billGates.BornYear);
            Console.WriteLine("Place Of Birth: " + billGates.PlaceOfBirth);

            Console.WriteLine("***********************************************");
            //пример 2
            // Создать объект Cat с помощью конструктора с 3-мя параметрами.
            // Полю Name у Animal будет прикреплено значение "Tom".
            // Полю Age у Cat будет прикреплено значение 3
            // Полю Height у Cat будет прикреплено значение 20.
            Cat tom = new Cat("Tom", 3, 20);
            Console.WriteLine("------");
            Console.WriteLine("Name = {0}", tom.Name);
            Console.WriteLine("Age = {0}", tom.Age);
            Console.WriteLine("Height = {0}", tom.Height);

            Console.WriteLine("------");

            // Вызвать метод унаследованный от класса Animal.
            tom.Sleep();

            // Вызвать метод Say() (класса Cat)
            tom.Say();

            Console.WriteLine("***********************************************");
            //пример 3
            Animal tom2 = new Cat("Tom", 3, 20);
            Console.WriteLine("Animal Sleep:");

            // Вызвать метод Sleep() у Animal
            tom.Sleep();


            bool isMouse = tom2 is Mouse; 
            Console.WriteLine("Tom is mouse? " + isMouse);

            bool isCat = tom2 is Cat;
            Console.WriteLine("Tom is cat? " + isCat);

            bool isAnimal = tom2 is Animal;
            Console.WriteLine("Tom is animal? " + isAnimal);
            Console.ReadLine();
        }
    }
}
