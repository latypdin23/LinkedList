using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    interface ICanMove
    {
        void Run();

        void Back();

        int GetVelocity();
    }
}
