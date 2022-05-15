using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Threading.Tasks;


namespace lab1
{
    class Person
    {
        private string _name;
        private string _surname;
        private System.DateTime _birthday;
        internal static Person _person;

        public Person() : this("Anastasiia", "Biletska", new DateTime(2002, 5, 25)) { } // конструктор без параметрів і з даними за замовчуванням

        public Person(string name, string surname, System.DateTime birthday)
        {
            Name = name;
            Surname = surname;
            BDay = birthday;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            init
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            init
            {
                _surname = value;
            }
        }

        public System.DateTime BDay
        {
            get
            {
                return _birthday;
            }

            init
            {
                _birthday = value;
            }
        }

        public int Year
        {
            get
            {
                return BDay.Year;
            }
            set
            {
                _birthday = new DateTime(BDay.Year + value, BDay.Month, BDay.Day);
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname}, {BDay.ToString()}";
        }

        public virtual string ToShortString()
        {
            return $"{Name} {Surname}";
        }
    }

}
