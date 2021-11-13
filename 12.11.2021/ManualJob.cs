using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public abstract class  ManualJob: AbstractJob
    {
        public ManualJob()
        {

        }

        // Выполнить абстрактный метод объявленный в родительком классе.
        // (Должно быть ключевое слово 'override').
        public override String GetJobName()
        {
            return "Manual Job";
        }
    }
}
