using System.Collections.Generic;

namespace DataAccess
{
    public class EntriesRepository
    {
        private readonly DateTimeOffsetPoCContext _context = new DateTimeOffsetPoCContext();

        public IEnumerable<Entry> Get()
        {
            return _context.Entries;
        }

        public void Add(Entry entry)
        {
            _context.Entries.Add(entry);
            _context.SaveChanges();
        }
    }
}
