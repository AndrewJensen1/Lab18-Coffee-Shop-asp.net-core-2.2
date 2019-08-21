using System.Collections.Generic;
using Lab18_Coffee_Shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab18_Coffee_Shop.Controllers.Models
{
    public class CoffeeHouseController : Controller
    {
        List<RegisterUser> listOfUsers = new List<RegisterUser>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUserToList(RegisterUser listUser)
        {
            string listUsersJson = HttpContext.Session.GetString("ListOfUsersSession");
            if (listUsersJson != null)
            {
                //This if-statement is retrieving any items already added to the shopping cart.
                listOfUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(listUsersJson);
            }

            return View(listOfUsers);
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
                string list = HttpContext.Session.GetString("ListOfUsersSession");
                if (list != null)
                {
                    listOfUsers = JsonConvert.DeserializeObject<List<RegisterUser>>(list);
                }
                listOfUsers.Add(newUser);
                HttpContext.Session.SetString("ListOfUsersSession", JsonConvert.SerializeObject(listOfUsers));
                //listOfUsers.Add()
                return RedirectToAction("Welcome", newUser);
            }
            else
            {
                return View(newUser);
            }
        }

        public IActionResult Welcome(RegisterUser user)
        {
            return View(user);
        }


        public IActionResult UserInfo(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                return View(newUser);

            }
            return RedirectToAction("Registration",newUser);
        }
        public IActionResult MyAccount(RegisterUser user)
        {
            return View(user);
        }
    }
}