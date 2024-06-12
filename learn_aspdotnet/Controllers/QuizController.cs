using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learn_aspdotnet.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult SendAnswer()
        //{
        //    return View();
        //}

        //public ActionResult SendAnswer(string answer)
        //{
        //    if (answer == "2")
        //    {
        //        //костыли
        //        //return Ok("правильно");
        //        return View("Ok");
        //    }
        //    //return BadRequest("не правильно");
        //    return View("BadRequest");
        //}
    }
}