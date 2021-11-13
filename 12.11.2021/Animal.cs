using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public abstract class Animal
    {
        public string Name;


        public Animal()
        {
            Console.WriteLine("- Animal()");
        }
        public Animal(string Name)
        {
            this.Name = Name;
            Console.WriteLine("- Animal(string)");
        }
        // Move(): Животное двигается.
        // virtual: Разрешить подклассу переопределить (override) данный метод.
        public virtual void Move()
        {
            Console.WriteLine("Animal Move");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
}
