using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        //write ctor then press tab twice to create a constructor
        ECommerceEntities _context;
        public BrandController()
        {
            _context = new ECommerceEntities();
        }
        public ActionResult Index()
        {
            var brand = _context.Brands.ToList();
            return View(brand);
        }
    }
}