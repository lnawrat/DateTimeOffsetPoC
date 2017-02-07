using System;
using System.Linq;
using System.Web.Mvc;
using Client.Models;
using DataAccess;

namespace Client.Controllers
{
    public class DemoController : Controller
    {
        private readonly EntriesRepository _repository = new EntriesRepository();
        public ActionResult Index()
        {
            return View(new DemoVm { Entries = _repository.Get().OrderByDescending(x => x.Id) } );
        }

        public ActionResult Add(int offset)
        {
            _repository.Add(new Entry
            {
                Name = $"new from client {offset}",
                Date = DateTimeOffset.Now.ToOffset(new TimeSpan(offset, 0, 0))
            });

            return RedirectToAction("Index");
        }
    }
}
