using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab4
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            Student stud = new Student(new Person("Anna", "Sagres", new System.DateTime(2001,1,1)), Education.Master, 301);

            WriteLine(stud.DeepCopy());
            //2)
            WriteLine("Enter name of the file, to record datas of the object:");
            stud.Save(ReadLine());
            WriteLine("Enter name of the file, to read datas of the object:");
            Student stud2 = new Student();
            stud2.Load(ReadLine());
            WriteLine(stud2);

            //3)
            stud.AddFromConsole();
            WriteLine("Enter name of the file, to record datas of the object:");
            stud.Save(ReadLine());
            WriteLine("Enter name of the file, to read datas of the object:");
            stud.Load(ReadLine());


            //4)
            WriteLine("Enter name of the file, to read datas of the object:");
            Student.Load(ReadLine(), stud);
            stud.AddFromConsole();
            WriteLine("Enter name of the file, to record datas of the object:");
            Student.Save(ReadLine(), stud);
            WriteLine("Enter name of the file, to read datas of the object:");
            Student.Load(ReadLine(), stud);


        }
    }
}