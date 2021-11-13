using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook bob = new Cook("Bob");
            bob.MakeDinner(new PotatoMeal());
            Console.WriteLine();
            bob.MakeDinner(new SaladMeal());
        }
    }
}
