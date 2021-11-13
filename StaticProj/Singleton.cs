using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProj
{
    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton source = null;

        public static Singleton Source
        {
            get
            {
                if (source == null)
                {
                    source = new Singleton();
                }

                return source;
            }
        }
    }
}
