using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab3
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            WriteLine("Task 1");
            StudentCollection studentCollection = new StudentCollection();
            studentCollection.AddDefaults();
            studentCollection.AddStudents(new Student[] { new Student(new Person("Artur", "Berezovskyi", new System.DateTime(2001, 11, 19)), Education.SecondEducation, 308) 
            { Exams = new List<Exam>() { new Exam("Math", 3, new System.DateTime(2022, 6, 09)), new Exam("PHP", 4, new System.DateTime(2022, 5, 25)) }, 
                Tests = new List<Test>() { new Test(), new Test("History", false), new Test("Ruby", true) } }, 
                new Student(new Person("Misha", "Telehuz", new System.DateTime(2003, 12, 13)), Education.Master, 102) 
                { Exams = new List<Exam>() { new Exam(), new Exam("Low", 3, new System.DateTime(2022, 6, 1)) }, Tests = new List<Test>() { new Test() } } });
            WriteLine(studentCollection);
            WriteLine();


            WriteLine("Task 2");
            WriteLine("Sorted by surname:\n");
            studentCollection.SortBySurname();
            WriteLine(studentCollection);
            WriteLine("Sorted by date:\n");
            studentCollection.SortByDate();
            WriteLine(studentCollection);
            WriteLine("Sorted by mark\n");
            studentCollection.SortByGrade();
            WriteLine(studentCollection.ToShortString());
            WriteLine();

            WriteLine("Task 3");
            WriteLine("The maximum average mark:");
            WriteLine(studentCollection.MaxGrade);
            WriteLine("Students with Master degree");
            foreach (Student st in studentCollection.TypeEducation)
            {
                WriteLine(st);
            }
            WriteLine(" The Group students with mark:");
            foreach (Student st in studentCollection.AverageMarkGroup(4.5))
            {
                WriteLine(st);
            }
            WriteLine();

            WriteLine("Task 4");
            TestCollections testCollection = new TestCollections(1000000);
            testCollection.TimeFinding(1000000);

        }
    }
}