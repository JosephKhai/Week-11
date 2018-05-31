using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11
{
    class Person
    {
        public string Firstname;
        public string Surname;
        public DateTime DateOfbirth;
        public float Height;
        public int ID;
        private List<Subject>subject;

        public Person(string F, string S, DateTime D, float H, int r)
        {
            Firstname = F;
            Surname = S;
            DateOfbirth = D;
            Height = H;
            ID = r;

        }
        public string Fullname()
        {
            return Firstname + " " + Surname;
        }

        public float CompareHeight(Person person)
        {
            return Height - person.Height;
        }

    }
}
