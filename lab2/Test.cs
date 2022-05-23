using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Test
    {

        private string _name;
        private bool _passed;

        public Test(string name, bool passed)
        {
            Name = name;
            Passed = passed;
        }

        public Test() : this(name: "Python", passed: true) { }

        public string Name
        {

            get
            {

                return _name;
            }

            set
            {
                _name = value;
            }




        }

        public bool Passed
        {
            get
            {
                return _passed;
            }

            set
            {
                _passed = value;
            }
        }


        public override string ToString()
        {
            return $"\nSubject:{Name}\nPassed - {Passed}\n";
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() * 17 + Passed.GetHashCode() * 19;
        }
    }
}
