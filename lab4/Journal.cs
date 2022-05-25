using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Journal
    {
        private List<JournalEntry> _journalEvents;

        public void StudCountChanged(object sender, StudentListHandlerEventArgs args)
        {
            if (_journalEvents == null)
            {
                _journalEvents = new List<JournalEntry>();
            }

            _journalEvents.Add(new JournalEntry(args.Name_of_collection, args.TypeChanges, args.Position));
        }



        public override string ToString()
        {

            StringBuilder res = new StringBuilder();
            if (_journalEvents != null)
            {

                foreach (JournalEntry journalEntry in _journalEvents)
                {
                    res.Append($"{journalEntry.ToString()}\n");
                }

                return $"Information about all changes:\n{res}";
            }

            else
            {
                return "List is null";
            }
        }
    }
}