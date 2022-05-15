using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            Console.WriteLine(student.ToShortString());

            Console.WriteLine(student[Education.Master]);
            Console.WriteLine(student[Education.Bachelor]);
            Console.WriteLine(student[Education.SecondEducation]);

            Student student1 = new()
            {
                Pers = new Person("Halyna", "Blyzniuk", new DateTime(2000, 4, 8)),
                Educ = Education.Bachelor,
                Group = 201,
                Passed_exams = new Exam[]
                {
                    new Exam("Software testing", 85, new DateTime(2022, 6,2)),
                    new Exam("C#", 73, new DateTime(2022, 6,7)),
                    new Exam("English", 91, new DateTime(2022, 6, 4))
                }

            };
            Console.WriteLine();
            Console.WriteLine(student1.ToString());

            student1.AddExams(new Exam[] {
                new Exam("PHP",87,new DateTime(2022, 6,5)),
                new Exam("Ruby", 79, new DateTime(2022, 6,7)),
                new Exam("Project managment", 88, new DateTime(2022, 6, 10))
            });
            Console.WriteLine(student1.ToString());
            //Console.WriteLine(student1.ToShortString());


            //article array
            string? input = Console.ReadLine();
            int nRows, nColumns;
            if (input == null)
            {
                return;
            }
            nRows = Convert.ToInt32(input.Split(' ', ',')[0]);
            nColumns = Convert.ToInt32(input.Split(' ', ',')[1]);
            Console.WriteLine(nRows);
            Console.WriteLine(nColumns);

            Exam[] examOne = new Exam[nRows * nColumns];
            Exam[,] examTwo = new Exam[nRows, nColumns];
            Exam[][] examJagged1 = new Exam[nRows][];
            Exam[][] examJagged2;

            for (int i = 0; i < examOne.Length; i++)
            {
                examOne[i] = new Exam();
            }

            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    examTwo[i, j] = new Exam();
                }
            }

            for (int i = 0; i < nRows; i++)
            {
                examJagged1[i] = new Exam[nColumns];
                for (int j = 0; j < nColumns; j++)
                {
                    examJagged1[i][j] = new Exam();
                }
            }

            int sum = 0, k = 0;
            while (sum <= nColumns * nRows)
            {
                k++;
                sum += k;
            }
            sum = sum - k;

            if (sum == nColumns * nRows)
            {
                k -= 1;
                examJagged2 = new Exam[k][];

                for (int i = 0; i < k; i++)
                {
                    examJagged2[i] = new Exam[i];
                    for (int j = 0; j < i; j++)
                    {
                        examJagged2[i][j] = new Exam();
                    }
                }

            }
            else
            {
                examJagged2 = new Exam[k][];

                for (int i = 0; i < k - 1; i++)
                {
                    examJagged2[i] = new Exam[i];
                    for (int j = 0; j < i; j++)
                    {
                        examJagged2[i][j] = new Exam();
                    }
                }
                examJagged2[k - 1] = new Exam[nRows * nColumns - sum];
                for (int j = 0; j < nRows * nColumns - sum; j++)
                {
                    examJagged2[k - 1][j] = new Exam();
                }
            }
            int begin = Environment.TickCount;
            for (int i = 0; i < examOne.Length; i++)
            {
                examOne[i].Subject = "newName";
            }
            int end = Environment.TickCount;
            Console.WriteLine(end - begin);

            begin = Environment.TickCount;

            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    examTwo[i, j].Subject = "newName";
                }
            }
            end = Environment.TickCount;
            Console.WriteLine(end - begin);


            begin = Environment.TickCount;
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    examJagged1[i][j].Subject = "newName";
                }
            }
            end = Environment.TickCount;
            Console.WriteLine(end - begin);


            begin = Environment.TickCount;
            for (int i = 0; i < examJagged2.Length; i++)
            {
                for (int j = 0; j < examJagged2[i].Length; j++)
                {
                    examJagged2[i][j].Subject = "newName";
                }
            }
            end = Environment.TickCount;
            Console.WriteLine(end - begin);
        }

    }
}
