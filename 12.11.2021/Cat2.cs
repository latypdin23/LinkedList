using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public class Cat2 : Animal2, ICanEat, ICanDrink
    {

        private String name;

        public Cat2(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }
        public override void Back()
        {
            Console.WriteLine(name + " cat back ...");
        }
        public override int GetVelocity()
        {
            return 110;
        }

        public void Eat()
        {
            Console.WriteLine(name + " cat eat ...");
        }
        public void Drink()
        {
            Console.WriteLine(name + " cat drink ...");
        }

    }
}
