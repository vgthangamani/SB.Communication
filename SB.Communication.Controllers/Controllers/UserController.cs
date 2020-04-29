using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SB.Communication.Controllers.Controllers
{
    public class UserController:Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Roles()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult HolidayList()
        {
            return View();
        }
        public ActionResult Approvals()
        {
            return View();
        }
        public ActionResult Reports()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
    }
}
