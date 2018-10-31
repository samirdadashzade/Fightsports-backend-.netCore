using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightSports.Models;
using Microsoft.AspNetCore.Mvc;

namespace FightSports.Controllers
{
    public class SecurityController : Controller
    {
        [HttpPost]
        public IActionResult Login(Admin admin,string _username, string _password)
        {
            string username = _username;
            string password = _password;

            if (username == admin.AdminName && password == admin.AdminPassword)
            {
                HttpContext.Session.Set("id", Encoding.UTF8.GetBytes("salam"));

                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}