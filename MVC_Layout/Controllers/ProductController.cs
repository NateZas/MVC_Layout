using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ECommerceEntities _context = new ECommerceEntities();
        public ProductController()
        {
            _context = new ECommerceEntities();
        }
        public ActionResult Index(string search ="")
        {
            //var product = _context.Products.ToList();
            ViewBag.search = search;
            var product = _context.Products.Where(temp => temp.ProductName.Contains(search)).ToList();
            return View(product);
        }

        public ActionResult Details(long id)
        {
            var product = _context.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
            var del = _context.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            _context.Products.Remove(del);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Update(long id)
        {
            var edit = _context.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(edit);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            var edit = _context.Products.Where(temp => temp.ProductID == product.ProductID).FirstOrDefault();
            edit.ProductName = product.ProductName;
            edit.Price = product.Price;
            edit.DateOfPurchase = product.DateOfPurchase;
            edit.AvailabilityStatus = product.AvailabilityStatus;
            edit.CategoryID = product.CategoryID;
            edit.BrandID = product.BrandID;
            edit.Active = product.Active;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}