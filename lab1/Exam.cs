using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Exam
    {
        private string _subject;
        private int _mark;
        private System.DateTime _exam_date;

        public Exam(string subject, int mark, System.DateTime exam_date)
        {
            Subject = subject;
            Mark = mark;
            Exam_date = exam_date;
        }
        public string Subject
        {
            get
            {
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
            }
        }
        public System.DateTime Exam_date
        {
            get
            {
                return _exam_date;
            }
            set
            {
                //_exam_date = new DateTime(Exam_date.Year + value,Exam_date.Month, Exam_date.Day) ;
                _exam_date = value;
            }
        }

        public Exam() : this ("C#",70, new DateTime(2022,6,2)) { }

        public override string ToString()
        {
            return $"{Subject}, {Mark}, {Exam_date}";
        }

    }
}
