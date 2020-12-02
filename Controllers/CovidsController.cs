using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace covidAPI.Controllers
{
    public class CovidsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
