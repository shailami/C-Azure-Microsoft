using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        Bank bank = new Bank {
            AccountNumber = 101,
            Amount = 100.0,
            AccountType="CURRENT ACCOUNT",
            Address="LALBAUG",
            AccHoldersName="SHAILAJA",
            Contact=9869023000,
            DOB=DateTime.Parse("11-03-1997"),
            EmailId="shailaja@gmail.com",
            CreationDate=DateTime.Now
               
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyAccount()
        {
            return View(bank);
        }

        public ActionResult Edit()
        {
            //Bank bank2 = bank;

            return View(bank);
        }
        public ActionResult GetDetailsForm()
        {
            return View();
        }
    }
}