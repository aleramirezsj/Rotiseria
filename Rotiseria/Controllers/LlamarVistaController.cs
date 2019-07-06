using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotiseria.Controllers
{
    public class LlamarVistaController: Controller
    {
        public ActionResult PartialRender()
        {
            return PartialView();
        }
    }
}