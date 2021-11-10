//using Microsoft.AspNetCore.Mvc;
//using MVC_Phone_Book.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.Encodings.Web;
//using System.Threading.Tasks;

//namespace MVC_Phone_Book.Controllers
//{
//    public class PersonController : Controller
//    {
//        private readonly PersonController _context;

//        public PersonController(MVC_Phone_BookContext context)
//        {
//            _context = context;
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }

//        // 
//        // GET: /Person/Welcome/ 

//        /* public string Welcome(string name, int numTimes = 1)
//         {
//             // https://localhost:{PORT}/HelloWorld/Welcome?name=Rick&numtimes=4
//             // /Welcome/3?name=Rick
//             //The URL segment Parameters isn't used.
//             // The name and numTimes parameters are passed in the query string.
//             //The ? (question mark) in the above URL is a separator,
//             //and the query string follows. The & character separates field-value pairs.

//             return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}"); }*/

//        public IActionResult Welcome(string name, int numTimes = 1)
//        {
//            ViewData["Message"] = "Hello " + name;
//            ViewData["NumTimes"] = numTimes;

//            return View();
//        }


//    }
//}
