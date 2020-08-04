using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VotingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SurveyQuiz()
        {
            var poll = new
            {
                question = "Who would you like to vote for?",
                choices = VotingHub.poll.Select(x => new { name = x.Key, count = x.Value }).ToList()
            };
            return Json(poll, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}