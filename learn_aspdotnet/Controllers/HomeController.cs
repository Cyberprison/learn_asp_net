using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learn_aspdotnet.Controllers
{
    //class User
    //{
    //    public int Age { get; set; }
    //    public string Name { get; set; }
    //}

    public class HomeController : Controller
    {
        

        public ActionResult PrintValue()
        {
            int age = 16;
            string name = "azazaza";
            //var user = new User
            //{
            //    Name = name,
            //    Age = age
            //};

            return View(name);

        }

        public ActionResult PrintValuesCollection()
        {
            var numbersList = new List<int>{ 0,1,2,3,4,5,6,7,8,9};
            var numbersArray = new string[] { "1", "2", "3" };
            //var users = new List<User>
            //{
            //    new User {Name = "aaa", Age = "111"},
            //    new User {Name = "bbb", Age = "222"},
            //    new User {Name = "ccc", Age = "333"}
            //};

            return View(numbersList);
        }

        public ActionResult Calculate(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;

            return View(result);
        }


        public ActionResult PrintInfo()
        {
            return View();
        }

        public ActionResult Index()
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