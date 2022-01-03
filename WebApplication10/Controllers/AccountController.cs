using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<Account> accounts = new List<Account>();
            accounts.Add(new Account() { ID = 100, AccHolderName = "Bhavya", AccHolderAddress = "Kadapa"});
            accounts.Add(new Account() { ID = 200, AccHolderName = "Navya", AccHolderAddress = "Kurnool" });
            accounts.Add(new Account() { ID = 300, AccHolderName = "Kavya", AccHolderAddress = "Nellore" });

            ViewData["accounts"] = accounts;

            return View();
        }
    }
}
