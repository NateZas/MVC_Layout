using MVC_Layout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Layout.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }        
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Book(int bookid)
        {
            return Content("Id:" + bookid);
        }
        //[Route("admin/admission/{year}/{month:regex}")]
        [Route("admin/admission/{year}/{month}")]
        public ActionResult StudentByAddmissionsDate(int year, int month)
        {
            return Content("year"+year+"month"+month);
        }
    }
}