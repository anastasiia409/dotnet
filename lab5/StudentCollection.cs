using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;


namespace lab4
{
    internal class StudentCollection
    {
        private List<Student>? _students;
        private string _nameCollection;
        public StudentCollection(string nameCollection)
        {
            _nameCollection = nameCollection;
        }

        public delegate void StudentListHandler(object sender, StudentListHandlerEventArgs args);

        public event StudentListHandler StudentCountChanged;

        public event StudentListHandler StudentReferenceChanged;
        public void Add(Student student)
        {
            if (_students == null)
            {
                _students = new List<Student>();
            }
            _students.Add(student);
            StudentCountChanged?.Invoke(this, new StudentListHandlerEventArgs(NameCollection, TypeChange.StudentAdded, _students.Count - 1));
        }
        public string NameCollection
        {
            get
            {
                return _nameCollection;
            }
        }
        public void AddDefaults()
        {
            if (_students == null)
            {
                _students = new List<Student>();
            }

            _students.Add(new Student());
            _students.Add(new Student(new Person("Kolia", "Hanek", new System.DateTime(2001, 05, 03)), Education.Master, 301)
            {
                Exams = new List<Exam>() { new Exam(), new Exam("Programming", 2, new System.DateTime
                (2022, 6, 3)) }
            });
        }

        public void AddStudents(Student[] students)
        {
            if (_students == null)
            {
                _students = new List<Student>();
            }

            int j = 0;
            while (j < students.Length)
            {
                _students.Add(students[j]);
                j++;
            }
        }
        public bool Remove(int j)
        {
            if (_students != null && j < _students.Count && j >= 0 && _students.Count != 0)
            {

                StudentCountChanged?.Invoke(this, new StudentListHandlerEventArgs(NameCollection, TypeChange.StudentDeleted, j));
                _students.Remove(_students[j]);
                return true;
            }

            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            if (_students != null)
            {

                foreach (Student stud in _students)
                {
                    res.Append($"Information about the student:\n{stud.Person}\nEducation: {stud.Educate}\nGroup: {stud.Group}\n\nList of exams:\n\n");
                    if (stud.Exams != null)
                    {
                        foreach (Exam ex in stud.Exams)
                        {
                            res.Append(ex);
                        }
                    }

                    res.Append("\nList zaliks:\n\n");

                    if (stud.Tests != null)
                    {
                        foreach (Test test in stud.Tests)
                        {
                            res.Append(test);
                        }
                    }

                    res.Append("\n");
                }

                return $"Information about all students:\n{res}";
            }

            else
            {
                return "List is null";
            }
        }
        public Student this[int i]
        {
            get
            {
                if (_students != null && _students.Count > i && i >= 0 && _students.Count != 0)
                {
                    return _students[i];
                }

                else
                {
                    return new Student();
                }
            }

            set
            {
                if (_students != null && _students.Count > i && i >= 0 && _students.Count != 0)
                {
                    _students[i].Group = value.Group;

                    StudentReferenceChanged?.Invoke(this, new StudentListHandlerEventArgs(NameCollection, TypeChange.StudentUpdated, i));
                }
            }
        }
        public string ToShortString()
        {
            StringBuilder res = new StringBuilder();

            if (_students != null && _students.Count != 0)
            {
                foreach (Student stud in _students)
                {
                    res.Append($"Information about student:\n{stud.Person}\nEducation: {stud.Educate}\nGroup: {stud.Group}\nAverage grade: {stud.AverageGrade}\nNumber tests: ");
                    if (stud.Tests == null)
                    {
                        res.Append("0\nNumber exams: ");
                    }
                    else
                    {
                        res.Append($"{stud.Tests.Count}\nNumber exams: ");
                    }

                    if (stud.Exams == null)
                    {
                        res.Append("0\n\n");
                    }
                    else
                    {
                        res.Append($"{stud.Exams.Count}\n\n");
                    }

                }

                return $"Information about students: {res}";
            }
            else
            {
                return "The list is null";
            }
        }

        public void SortBySurname()
        {

            if (_students != null)
            {
                _students.Sort();
            }
        }

        public void SortByDate()
        {
            if (_students != null)
            {
                _students.Sort(new Person());
            }
        }

        public void SortByGrade()
        {
            if (_students != null)
            {
                _students.Sort(new StudentComparer());
            }
        }

        public double MaxGrade
        {
            get
            {
                if (_students == null || _students.Count == 0)
                {
                    return 0;
                }

                else
                {
                    return _students.Max(x => x.AverageGrade);

                }
            }
        }

        public IEnumerable<Student> TypeEducation
        {
            get
            {
                if (_students == null || _students.Count == 0)
                {
                    return Enumerable.Empty<Student>();
                }
                return _students.Where(student => student.Educate == Education.Master);

            }
        }

        public List<Student> AverageMarkGroup(double mark)
        {




            return (_students?.GroupBy(stud => stud.AverageGrade).FirstOrDefault(x => x.Key == mark) ?? Enumerable.Empty<Student>()).ToList(); ;



        }
    }
}