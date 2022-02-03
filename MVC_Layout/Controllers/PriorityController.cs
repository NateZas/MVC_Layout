using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class PriorityController : Controller
    {
        ECommerceEntities _context = new ECommerceEntities();
        // GET: Priority
        public ActionResult Index()
        {
            return View(_context.tests.OrderBy(p => p.py).ToList());
        }

        [HttpPost]
        public ActionResult Index(int[] id)
        {
            int pr = 1;
            foreach (int hi in id)
            {
                var testy = _context.tests.Find(hi);
                testy.py = pr;
                _context.SaveChanges();
                pr += 1;

            }
            return View(_context.tests.OrderBy(p => p.py).ToList());
        }
    }

}