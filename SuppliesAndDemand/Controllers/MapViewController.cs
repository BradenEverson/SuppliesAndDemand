using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliesAndDemand.Web.Controllers
{
    public class MapViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
