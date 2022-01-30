using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class CatagoryController : Controller
    {
        // GET: Catagory
        ECommerceEntities _context = new ECommerceEntities();
        public ActionResult Index()
        {
            var category = _context.Categories.ToList();
            return View(category);
        }
    }
}