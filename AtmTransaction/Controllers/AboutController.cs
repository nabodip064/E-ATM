using AtmTransaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtmTransaction.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Withdraw(logInData data)
        {
            MyDbContex myDbContex = new MyDbContex();
            var value = myDbContex.userData.Where(a => a.card_number.Equals(data.Card_Number)).First();
            //value.balance -= data.Account_Balance;
            //myDbContex.SaveChanges();
            var v = value.balance;
            return RedirectToAction("Index");
        }
    }
}