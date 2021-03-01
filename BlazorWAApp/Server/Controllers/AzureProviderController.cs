using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWAApp.Server.Controllers
{
    public class AzureProviderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
