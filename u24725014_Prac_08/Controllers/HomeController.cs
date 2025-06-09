using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Cryptography.X509Certificates;
using u24725014_Prac_08.Models;

namespace u24725014_Prac_08.Controllers
{
    public class HomeController : Controller
    {

        public static List<Polygon> shapes = new List<Polygon>();
        public ActionResult Index()
        {
            return View(shapes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult AddShape()
        {
            return View();
        }
        public ActionResult Rectangle()
        {
            return View();
        }

        public ActionResult AddRectangle(Rectangle p)
        {
            shapes.Add(p);
            return RedirectToAction("index");
        }

        public ActionResult Ellipse()
        {
            return View();
        }
        public ActionResult AddEllipse(Ellipse e)
        {
            shapes.Add(e);
            return RedirectToAction("index");
        }

        public ActionResult Triangle()
        {
            return View();
        }
        public ActionResult AddTriangle(Triangle e)
        {
            shapes.Add(e);
            return RedirectToAction("index");
        }

        public ActionResult Square()
        {
            return View();
        }
        public ActionResult AddSquare(Square s)
        {
            shapes.Add(s);
            return RedirectToAction("index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}