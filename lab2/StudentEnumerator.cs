using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class StudentEnumerator : Student, IEnumerator
    {
        private ArrayList? _examName;
        private ArrayList? _testName;
        private ArrayList? _result;
        private int position = -1;


        public StudentEnumerator(ArrayList nameExam, ArrayList nameTest)
        {

            _examName = nameExam;
            _testName = nameTest;
            _result = new ArrayList();
        }
        public object? Current
        {
            get
            {
                if (position == -1 || position >= _examName?.Count)
                {
                    throw new ArgumentException();
                }

                foreach (string nameExam in _examName)
                {
                    foreach (string nameTest in _testName)
                    {
                        if (nameExam == nameTest)
                        {
                            _result?.Add(nameExam);
                        }
                    }
                }
                _examName.Clear();
                _examName = _result;
                return _name[position];
            }
        }

        public bool MoveNext()
        {
            if (position < _examName?.Count - 1)
            {

                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            position = -1;
        }
    }

}