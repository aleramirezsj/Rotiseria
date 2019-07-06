using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rotiseria.Models
{
    public class RenderActionViewModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public object RouteValues { get; set; }
    }
}