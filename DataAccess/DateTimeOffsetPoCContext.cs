using System.Data.Entity;

namespace DataAccess
{
    internal class DateTimeOffsetPoCContext : DbContext
    {
        public DateTimeOffsetPoCContext()
            :base("DemoDbConnection")
        {
        }

        public DbSet<Entry> Entries { get; set; }
    }
}
