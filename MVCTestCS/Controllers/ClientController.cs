using MVCTestCS.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCS.Controllers
{
    public class ClientController : Controller
    {

        private CarDealerEntities db = new CarDealerEntities();

        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetVehiclesList()
        {

           
            return Json(db.CarModels.ToList(), JsonRequestBehavior.AllowGet);

        }


    }
}