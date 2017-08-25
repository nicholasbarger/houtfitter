using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Logic;
using Web.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class SignupController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public IActionResult IndexPost(User user)
        {
            // todo

            return RedirectToAction("Interests");
        }

        public IActionResult Interests()
        {
            var logic = new TopicLogic();
            ViewBag.Interests = logic.GetTopicInterests();

            return View();
        }
    }
}
