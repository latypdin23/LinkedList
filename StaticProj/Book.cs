using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProj
{
    class Book
    {
        public int Price;
        static public string Value;
        public Book()
        {
            Price = 10;
            Console.WriteLine("public Book()");
        }
        static Book()
        {
            Value = "Hello";
            Console.WriteLine("static Book()");
        }
    }
}
