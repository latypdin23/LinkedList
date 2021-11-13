using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public abstract class Animal2 : ICanMove
    {

        // Выполнить метод Run() interface CanMove.
        // Вам нужно написать содержание метода.
        // Modifier должен быть public.
        public void Run()
        {
            Console.WriteLine("Animal run...");
        }

        // Если данный класс не выполнит определенный метод Interface
        // вам нужно переписать его как абстрактный метод.
        // (Всегда 'public abstract')
        public abstract void Back();

        public abstract int GetVelocity();

    }
}
