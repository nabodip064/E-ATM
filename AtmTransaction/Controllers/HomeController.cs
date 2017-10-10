using AtmTransaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtmTransaction.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        //public ActionResult LogIn(AtmTransaction.Models.UserData dataModel)
        //{
            
        //    return View(dataModel.card_number);
        //}
        public ActionResult About(logInData data)
        {
            ViewBag.Message = "Card number is "+data.Card_Number+" & Pin number is "+data.Pin_Number;

            MyDbContex myDbContex = new MyDbContex();
            var variable = myDbContex.userData.Where(a => a.card_number.Equals(data.Card_Number)
            && a.pinNumber.Equals(data.Pin_Number)).FirstOrDefault();

            if(variable != null)
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}