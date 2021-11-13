using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._11._2021
{
    class Person
    {
        public String Name;

        public int BornYear;

        public String PlaceOfBirth;

        public Person(String Name, int BornYear, String PlaceOfBirth)
        {
            this.Name = Name;
            this.BornYear = BornYear;
            this.PlaceOfBirth = PlaceOfBirth;
        }
        public Person(String Name, int BornYear)
        {
            this.Name = Name;
            this.BornYear = BornYear;
        }
    }
}
