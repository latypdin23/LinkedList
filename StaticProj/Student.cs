using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProj
{
    class Student
    {
        public static int a;
        public Student(string name)
        {
            this.name = name;
        }
        public string Name { get { return name; } set { name = value; } }
        public static string About { get { return about; } }
        private string name; 

        private static string about = "Класс, для представления простых студентов в программах, написанных на C#";

        public static void GetSome()
        {
            Console.WriteLine(about);
        }
    }
}
