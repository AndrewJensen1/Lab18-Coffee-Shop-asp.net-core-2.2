using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab18_Coffee_Shop.Controllers
{
    public class CoffeeHouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegisterUser());
        }
        [HttpPost]
        public IActionResult Registration(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome", newUser);

            }
            return View(newUser);
        }

        public IActionResult Welcome(RegisterUser user)
        {
            return View(user);
        }

        [HttpGet]
        public IActionResult UserInfo()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult UserInfo(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                return View(newUser);

            }
            return RedirectToAction("Registration",newUser);
        }
        public IActionResult MyAccount(User user)
        {
            return View(user);
        }
    }
}