using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPostCore.Controllers
{
    [Route("Search")]
    public class SearchController : Controller
    {
        [HttpPost]
        public IActionResult Search(string term, DateTime magic)
        {
            return RedirectToAction("Search", new { term = term });
        }

        [Route("Search/{term}")]
        public IActionResult Search(string term)
        {
            ViewBag.Term = term;
            return View();
        }
    }
}
