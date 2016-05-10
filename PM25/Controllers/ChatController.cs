using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PM25.Controllers
{
    public class ChatController: Controller
    {
        public ActionResult Chat()
        {
            return View();
        }
    }
}