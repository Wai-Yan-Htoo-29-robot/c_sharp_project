using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
//using Microsoft.AspNetCore.Mvc;
//using System.Text.Encodings.Web;

//namespace MvcMovie.Controllers
//{
//    public class HelloWorldController : Controller
//    {
//        // 
//        // GET: /HelloWorld/

//        public string Index()
//        {
//            return "This is my default action...really";
//        }

//        // 
//        // GET: /HelloWorld/Welcome/ 

//        public string Welcome()
//        {
//            return "This is the Welcome action method...";
//        }
//    }
//}
