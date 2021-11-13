using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public abstract class AbstractJob
    {

        public AbstractJob()
        {

        }

        // Это абстрактный метод,
        // Он не имеет тела (body).
        // Данный метод возвращает название работы.
        public abstract String GetJobName();

        // Это абстрактный метод,
        // Метод не имеет тела (body).
        public abstract void DoJob();

        // Это обычный метод (Неабстрактный).
        public void StopJob()
        {
            Console.WriteLine("Stop");
        }
    }
}
