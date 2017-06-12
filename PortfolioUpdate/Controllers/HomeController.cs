using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PortfolioUpdate.Controllers
{
    public class HomeController : Controller
    {
        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    base.OnActionExecuted(context);
        //    var result = context.Result as ViewResult;
        //    if (result != null)
        //    {
        //        result.ViewData["BackgroundImage"] = "yosemite.jpg";
        //    }
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
