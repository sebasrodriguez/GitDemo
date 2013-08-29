using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UruIT.ThinkTank.Demo.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            // test
            return View();
        }

        public ActionResult Add() 
        {
            return View("AddView3");
        }

        public ActionResult Edit() 
        {
            return View("EditView");
        }

        public ActionResult View() 
        {
            return View();
        }

        public ActionResult Detail() 
        {
            return View();
        }
    }
}
