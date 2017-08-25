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
    public class TopicController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string s)
        {
            var logic = new TopicLogic();
            var filter = new TopicFilter()
            {
                SearchTerms = s
            };

            ViewBag.SearchTerms = s;
            ViewBag.Topics = logic.GetTopics(filter);

            return View();
        }

        // GET: /<controller>/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost(Topic topic)
        {
            // validate topic (there is an asp.net way of doing this with 
            // model.state or something
            var logic = new TopicLogic();
            logic.ValidateTopic(topic);

            return View();
        }

        // GET: /<controller>/Detail
        public IActionResult Detail(string name)
        {
            var logic = new TopicLogic();
            ViewBag.Topic = logic.GetByName(name);

            return View();
        }
    }
}
