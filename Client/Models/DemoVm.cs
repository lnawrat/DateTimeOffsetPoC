using System.Collections.Generic;
using DataAccess;

namespace Client.Models
{
    public class DemoVm
    {
        public IEnumerable<Entry> Entries { get; set; }
    }
}
