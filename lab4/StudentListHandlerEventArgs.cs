using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class StudentListHandlerEventArgs : System.EventArgs
    {

        string _name_of_collection;
        TypeChange _typeChanges;
        int _position;


        public StudentListHandlerEventArgs(string name_of_collection, TypeChange typeChanges, int position)
        {
            _name_of_collection = name_of_collection;
            _typeChanges = typeChanges;
            _position = position;
        }

        public string Name_of_collection
        {
            get
            {
                return _name_of_collection;
            }

            init
            {
                _name_of_collection = value;
            }
        }

        public TypeChange TypeChanges
        {
            get
            {
                return _typeChanges;
            }

            init
            {
                _typeChanges = value;
            }
        }

        public int Position
        {
            get
            {
                return _position;
            }

            init
            {
                _position = value;
            }
        }

        public override string ToString()
        {
            return $"Information about changes:\nName collection: {Name_of_collection}\nThe changing type: {TypeChanges}\nThe changed student: {Position}\n";
        }
    }
}