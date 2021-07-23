using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Carnation.NewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carnation.Controllers
{
    public class Account : Controller
    {
        public readonly ISession session;
        public Account(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
           
        }
        public IActionResult Login()
        {
           
            return View();
        }
       

        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            bool sul, mul, aul = false;

            using (var ct = new CarnationDbContext())
            {
                sul = ct.SimpleUserRegisters.Any(x => x.UserName == username && x.Pass == password);
                mul = ct.MerchantUserRegisters.Any(y => y.UserName == username && y.Pass == password);
                aul = ct.AdminTables.Any(z => z.UserName == username && z.Pass == password);

            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }
            ClaimsIdentity identity = null;
            bool A = false;
          
            if (sul)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Role,"SimpleUser"),
                    new Claim(ClaimTypes.Name,username)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                A = true;
                HttpContext.Session.SetString("usertype", "simple");
                HttpContext.Session.SetString("username", username);

            }

            else if (mul)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Role,"MerchantUser"),
                    new Claim(ClaimTypes.Name,username)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                A = true;
                HttpContext.Session.SetString("usertype", "merchant");
                HttpContext.Session.SetString("username", username);
                

            }
            else if (aul)
            {
                A = true;
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Role,"Admin"),
                    new Claim(ClaimTypes.Name,username)
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                HttpContext.Session.SetString("usertype", "admin");
                HttpContext.Session.SetString("username", username);
            }
            else
            {
                A = false;
                HttpContext.Session.SetString("usertype", "anonymous");
            }

            if (A)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                if(mul)
                {
                    return RedirectToAction("Merchant", "Home");
                }
                else if(aul)
                {
                    return RedirectToAction("Admin", "Home");

                }
                else
                {
                    return RedirectToAction("Index", "Products");
                }
              

            }



            return View();
        }


        public IActionResult LogOut()
        {
            session.Clear();
            Response.Cookies.Delete("");
            return RedirectToAction("Login", "Account");
        }

    }
}
