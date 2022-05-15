using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Student
    {
        private Person _person;
        private Education _education;
        private int _group;
        private Exam[] _passed_exams;

        public Student(Person person, Education education, int group)
        {
            Pers = person;
            Educ = education;
            Group = group;
            //Passed_exams = passed_exams;
        }
        public Student() : this(new Person(), Education.Bachelor, 201)
        {
            //Passed_exams = passed_exams;
        }
        public Exam[] Passed_exams
        {
            get
            {
                return _passed_exams;
            }
            init
            {
                _passed_exams = value;
            }
        }
        public Person Pers
        {
            get
            {
                return _person;
            }
            init
            {
                _person = value;
            }
        }
        public Education Educ
        {
            get
            {
                return _education;
            }
            init
            {
                _education = value;
            }
        }
        public int Group
        {
            get
            {
                return _group;
            }
            init
            {
                _group = value;
            }
        }

        public double Average_mark
        {
            get
            {
                if (Passed_exams == null || Passed_exams.Length == 0)
                {
                    return 0;
                }
                double avgMark = 0;

                foreach (Exam article in Passed_exams)
                {
                    avgMark += article.Mark;
                }
                return avgMark / Passed_exams.Length;

            }
        }
        public bool this [Education e]
        {
            get
            {
                return e == Educ;
            }
        }

        public void AddExams(Exam[] param)
        {
            if (((param == null || param.Length == 0) && (Passed_exams == null || Passed_exams.Length == 0)) ||
                ((param == null || param.Length == 0) && !(Passed_exams == null || Passed_exams.Length == 0)))
            {
                return;

            }
            else if (!(param == null || param.Length == 0) && (Passed_exams == null || Passed_exams.Length == 0)) // якщо ще нема жодного записаного екзамену
            {
                _passed_exams = param;
            }

            else
            {
                Exam[] newExam = new Exam[Passed_exams.Length + param.Length]; 
                for (int i = 0; i < Passed_exams.Length; i++)
                {
                    newExam[i] = Passed_exams[i];
                }
                for (int i = Passed_exams.Length; i < Passed_exams.Length + param.Length; i++)
                {
                    newExam[i] = param[i - Passed_exams.Length];
                }
                _passed_exams = newExam;
            }
        }

        public override string ToString()
        {
            StringBuilder exams = new StringBuilder(); // 
            foreach (Exam passed_exams in Passed_exams)
            {
                exams.AppendLine(passed_exams.ToString());
            }
            return Pers + ", " + Educ.ToString() + ", " + Group.ToString() + "\nExams:\n" + exams;
        }

        public virtual string ToShortString()
        {
            return Pers + " Education - " + Educ.ToString() + ", group - " + Group.ToString() + " Average mark - " + Average_mark;
        }
    }
}
