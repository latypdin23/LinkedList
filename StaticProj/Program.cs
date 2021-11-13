using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book b = new Book();
            //Book b2 = new Book();

            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);
            Console.ReadKey();
        }
    }
}
