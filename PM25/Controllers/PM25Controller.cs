using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PM25.Controllers
{
    public class PM25Controller: Controller
    {
        public ActionResult PM25()
        {
            return View();
        }

        public ActionResult PM25js()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        }
    }
}