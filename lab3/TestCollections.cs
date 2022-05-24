using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab3
{
    internal class TestCollections
    {
        private List<Person> _persons;
        private List<string> _strings;
        private Dictionary<Person, Student> _personStudent;
        private Dictionary<string, Student> _stringStudent;

        public TestCollections(int count)
        {

            if (_persons == null) { _persons = new List<Person>(); }
            if (_strings == null) { _strings = new List<string>(); }
            if (_personStudent == null) { _personStudent = new Dictionary<Person, Student>(); }
            if (_stringStudent == null) { _stringStudent = new Dictionary<string, Student>(); }

            for (int i = 1; i <= count; i++)
            {

                Person person = GenerateStudent(i).Person;
                Student student = GenerateStudent(i);
                _persons.Add(person);
                _strings.Add(person.ToString());
                _personStudent.Add(person, student);
                _stringStudent.Add(person.ToString(), student);
            }
        }

        public static Student GenerateStudent(int i)
        {
            return new Student(new Person("Serhii" + i, "Johnson" + i, new System.DateTime(2000, 4, 4)), Education.Bachelor, 401);
        }

        public void TimeFinding(int count)
        {
            int start, end;
            Person pers = GenerateStudent(0).Person;
            Student student = GenerateStudent(0);
            WriteLine("\n\nThe first element:\n");

            WriteLine("The time in list <Person>:\n");
            start = Environment.TickCount;
            _persons.Contains(pers);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in List <string>:\n");
            start = Environment.TickCount;
            _strings.Contains(pers.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by key:\n");
            start = Environment.TickCount;
            _personStudent.ContainsKey(pers);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <string,Student> by key:\n");
            start = Environment.TickCount;
            _stringStudent.ContainsKey(pers.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by value:\n");
            start = Environment.TickCount;
            _personStudent.ContainsValue(student);
            end = Environment.TickCount;
            WriteLine(end - start);



            WriteLine("\n\nThe central element\n");

            Person pers1 = GenerateStudent(count / 2).Person;
            Student student1 = GenerateStudent(count / 2);
            WriteLine("The time in list <Person>:\n");
            start = Environment.TickCount;
            _persons.Contains(pers1);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in list <string>\n");
            start = Environment.TickCount;
            _strings.Contains(pers1.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by key:\n");
            start = Environment.TickCount;
            _personStudent.ContainsKey(pers1);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <string,Student> by key:\n");
            start = Environment.TickCount;
            _stringStudent.ContainsKey(pers1.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by value:\n");
            start = Environment.TickCount;
            _personStudent.ContainsValue(student1);
            end = Environment.TickCount;
            WriteLine(end - start);



            WriteLine("\n\nThe last element\n");

            Person pers2 = GenerateStudent(count - 1).Person;
            Student student2 = GenerateStudent(count - 1);
            WriteLine("The time in list <Person>\n");
            start = Environment.TickCount;
            _persons.Contains(pers2);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in list <string>:\n");
            start = Environment.TickCount;
            _strings.Contains(pers2.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by key:\n");
            start = Environment.TickCount;
            _personStudent.ContainsKey(pers2);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <string,Student> by key:\n");
            start = Environment.TickCount;
            _stringStudent.ContainsKey(pers2.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by value:\n");
            start = Environment.TickCount;
            _personStudent.ContainsValue(student2);
            end = Environment.TickCount;
            WriteLine(end - start);



            WriteLine("\nElement which isn't a collection:\n");
            Person pers3 = GenerateStudent(count).Person;
            Student student3 = GenerateStudent(count);

            WriteLine("The time in list <Person>:\n");
            start = Environment.TickCount;
            _persons.Contains(pers3);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in list <string>:\n");
            start = Environment.TickCount;
            _strings.Contains(pers3.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by key:\n");
            start = Environment.TickCount;
            _personStudent.ContainsKey(pers3);
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <string,Student> by key:\n");
            start = Environment.TickCount;
            _stringStudent.ContainsKey(pers3.ToString());
            end = Environment.TickCount;
            WriteLine(end - start);

            WriteLine("The time in dictionary <Person,Student> by value:\n");
            start = Environment.TickCount;
            _personStudent.ContainsValue(student3);
            end = Environment.TickCount;
            WriteLine(end - start);
        }

    }
}