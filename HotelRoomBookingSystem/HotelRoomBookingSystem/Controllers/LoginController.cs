using HotelRoomBookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRoomBookingSystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult LoginView(string z, string b)
        {
            return View("~/Views/Login.cshtml");
        }

        [HttpPost]
        public IActionResult AuthenticateUser(User user)
        {
            bool isUserAuthenticated = true;
            var x = HttpContext.Session.GetString("userName");

            if (isUserAuthenticated)
            {
                HttpContext.Session.SetString("userName", user.Username);
                return View("~/Views/Home/Home.cshtml");
            }
            else
                return View("~/Views/Login.cshtml");
        }

        //[Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userName");
            return RedirectToAction("LoginView");
        }


    }
}
