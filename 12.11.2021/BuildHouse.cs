using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public class BuildHouse : ManualJob
    {

        public BuildHouse()
        {

        }

        // Развернуть абстрактный метод родительского класса.  
        // (Нужно использовать ключевое слово 'override').
        public override void DoJob()
        {
            Console.WriteLine("Build a House");
        }

    }
}
