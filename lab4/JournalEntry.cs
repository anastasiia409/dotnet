using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class JournalEntry
    {
        string _nameCollection;
        TypeChange _typeChanges;
        int _position;


        public JournalEntry(string nameCollection, TypeChange typeChanges, int position)
        {
            _nameCollection = nameCollection;
            _typeChanges = typeChanges;
            _position = position;
        }

        public string NameCollection
        {
            get
            {
                return _nameCollection;
            }

            init
            {
                _nameCollection = value;
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
            return $"Information about changes:\nThe name of collection: {NameCollection}\nThe changing type: {TypeChanges}\nThe changed student: {Position}\n";
        }
    }
}