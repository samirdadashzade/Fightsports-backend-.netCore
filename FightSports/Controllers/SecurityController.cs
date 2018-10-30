using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FightSports.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace FightSports.Controllers
{
    public class SecurityController : Controller
    {
        public  CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext _context;

        public SecurityController(CUSERSRUSTAMDOCUMENTSFIGHTSPORTSMDFContext context)
        {
            _context = context;
        }

        [BindProperty]
        public LoginData loginData { get; set; }

        public async Task<IActionResult> LoginAsync(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var isValid = (loginData.Username == "rustam" && loginData.Password == "rustam");
                if (!isValid)
                {
                    ModelState.AddModelError("", "username or password is invalid");
                    return View();
                }
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, loginData.Username));
                identity.AddClaim(new Claim(ClaimTypes.Name, loginData.Username));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("", "username or password is blank");
                return View();
            }
        }

        public class LoginData
        {
            [Required]
            public string Username { get; set; }

            [Required, DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}