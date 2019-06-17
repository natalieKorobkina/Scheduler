using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scheduler.Controllers
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

        public ActionResult StudentView()
        {

            return View();
        }

        public ActionResult InstructorView()
        {

            return View();
        }

<<<<<<< HEAD
    }
||||||| merged common ancestors
        public ActionResult StudentView()
        {

            return View();
        }
    }
=======
        public ActionResult StudentView()
        {

            return View();
        }

        public ActionResult RoomView()
        {

            return View();
        }
    }

>>>>>>> e36030bfc065d8e77d5ed0f2bc6494a8e885ecb9
}