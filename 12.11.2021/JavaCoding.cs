using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public class JavaCoding : AbstractJob
    {

        public JavaCoding()
        {
        }

        // Выполняет абстрактный метод объявленный в родительском классе.
        // Он не имеет тела (body).
        // (Должно быть ключевое слово 'override').
        public override void DoJob()
        {
            Console.WriteLine("Coding Java...");
        }

        // Выполняет абстрактный метод родительского класса.
        public override String GetJobName()
        {
            return "Java Coding";
        }

        public void TestExample()
        {
            Console.WriteLine("Testing Example...");
        }
    }

}
