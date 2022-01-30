using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Layout.Models;

namespace MVC_Layout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Student()
        {
            var student = new List<Student>()
            {
                new Student{Id=101,Name="Abebe",Grade=3},
                new Student{Id=102,Name="Liya",Grade=4},
                new Student{Id=103,Name="Adonai",Grade=5}
            };
            ViewBag.Student = student;
            return View();
        }
        //first method to fill form
        public ActionResult std()
        {
            return View();
        }
        //second one to post results
        [HttpPost]
        //can call complete model as such or individual items
        public ActionResult std(Student student)
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}