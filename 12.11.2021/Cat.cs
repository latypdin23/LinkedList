using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public class Cat : Animal
    {
        public int Age;
        public int Height;
        public Cat(string name, int Age, int Height)
            : base(name)
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(string,int,int)");
        }
        public Cat(int Age, int Height)
            : base()
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(int,int)");
        }
        public void Say()
        {
            Console.WriteLine("Meo");
        }
        public override void Move()
        {
            Console.WriteLine("Cat Move ...");
        }
    }
}
