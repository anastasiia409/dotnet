using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab2
{
    internal class Programs
    {
        public static void Main(string[] args)
        {
            
            WriteLine("Task 1");
            Person person1 = new Person();
            Person person2 = new Person();

            WriteLine($"Person 1 == person 2 {person1.Equals(person2)}");
            WriteLine($"The hash code for person 1 {person1.GetHashCode()}");
            WriteLine($"The hash code for person 2 {person2.GetHashCode()}");
            WriteLine();

            WriteLine("Task 2");
            Student student = new Student();
            Exam[] newExams = new Exam[] { new Exam("PHP", 3, new System.DateTime(2021, 05, 25)), new Exam("Testing", 2, new System.DateTime(2021, 06, 06)) };
            Test[] newTests = new Test[] { new Test("PHP", true), new Test("C", false) };
            student.AddExams(newExams);
            student.AddTests(newTests);

            WriteLine(student);
            WriteLine();

            WriteLine("Task 3");
            WriteLine($"The Person of student\n{student.Person}");
            WriteLine();

            WriteLine("Task 4");
            Student studentCopy = (Student)student.DeepCopy();
            Test[] tests = new Test[] { new Test("History", true) };
            student.AddTests(tests);
            WriteLine($"Original object\n{student}");
            WriteLine($"Copy object\n{studentCopy}");
            WriteLine();

            WriteLine("Task 5");
            try
            {
                Student student2 = new Student() { Group = 700 };
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
            WriteLine();

            WriteLine("Task 6");
            foreach (object obj in student.AllGoodExams(3))
            {
                WriteLine(obj);
            }
            WriteLine();

            WriteLine("Task 7");
            WriteLine("Name of subjects which are peresent in tests and exams");
            foreach (var subject in student)
            {
                WriteLine(subject);
            }
            WriteLine();

            WriteLine("Task 8");
            WriteLine("Passed exams and tests");
            foreach (object obj in student.PassedTestsAndExams())
            {
                WriteLine(obj);
            }
            WriteLine();

            
            WriteLine("Task 9");
            WriteLine("Passed only tests");
            foreach (Test test in student.PassedOnlyTests())
            {
                WriteLine(test);
            }
        }
    }
}