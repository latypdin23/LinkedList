using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    public class Mouse : Animal
    {
        private int Weight;

        // Constructor по умолчанию (Не имеет параметра).
        // Вызывает Mouse(int)
        public Mouse()
            : this(100)
        {
        }
        // Данный Constructor имеет 1 параметр.
        // И не определяет :base
        // Значит он base (основывается) на Constructor по умолчанию родительского класса.
        public Mouse(int Weight)
        {
            this.Weight = Weight;
        }
        // Данный Constructor имеет 2 параметра.
        public Mouse(String name, int Weight)
            : base(name)
        {
            this.Weight = Weight;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public void SetWeight(int Weight)
        {
            this.Weight = Weight;
        }
    }
}
