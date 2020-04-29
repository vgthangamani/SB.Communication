using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SB.Communication.Controllers.Controllers
{
    public class AccountController: Controller
    {
        public ActionResult Login()
        {
            return PartialView("~/Views/Account/_Login.cshtml");
        }   
    }
}
