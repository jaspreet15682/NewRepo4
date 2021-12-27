using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demotraffic.Controllers
{
    public class HomeController : Controller
    {
        private UserDbContext db = new UserDbContext();

        public ActionResult Index()
        {
            return View(db.User.ToList());
            
        }

        public ActionResult About()
        {
            //trafficappEntities obj = new trafficappEntities();
            //User user = new User() { City = "ambala", Name = "jaspreet" };
            //obj.Users.Add(user);
            //obj.SaveChanges();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}