using MVCTestCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Details(int? id=null)
        {

            ViewBag.Title = "Dettagli";

            //return null;//blank page
            //return View("Index");
            //return RedirectToAction("Index");





            if (id.HasValue)
            {

                Models.Vehicle v = new Models.Vehicle();
                v.Name = "TestName";
                v.Type = "Golf";
                v.id = id.Value;



                return View(v);
            }
            else
            {
                return RedirectToAction("Index");
            }

            //return File("~/App_Data/IIS.txt",System.Net.Mime.MediaTypeNames.Application.Octet,"File.txt");
        }

        public ActionResult List()
        {

            ViewBag.Title = "Lista Veicoli";


            List<Vehicle> list_vehicle = new List<Vehicle>();
            Models.Vehicle v = new Models.Vehicle();
            v.Name = "TestName";
            v.Type = "Golf";
            v.id = 123;

            Models.Vehicle v1 = new Models.Vehicle();
            v1.Name = "TestName";
            v1.Type = "Golf";
            v1.id = 124;

            list_vehicle.Add(v);
            list_vehicle.Add(v1);

            return View(list_vehicle);

        }   
    }
}