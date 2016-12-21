using Microsoft.AspNetCore.Mvc;
using ZipShare.ViewModels;
using ZipShare.Models;
using ZipShare.DataAccess;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ZipShare.Controllers
{
    public class AccountController: Controller
    {
        public List<State> states;

        [HttpGet]
        public IActionResult Register()
        {
            states = Address.LoadStatesFromJSON();
            var model = new UserRegisterModel();
            model.States = new SelectList(states, "StateAbbreviation","StateName");
            return View(model);
        }

        [HttpPost]
        [ActionName("Register")]
        [AutoValidateAntiforgeryTokenAttribute]
        public IActionResult RegisterPost(UserRegisterModel model)
        {
            var user = new User()
            {
                //get data
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password // make sure this is encrypted
            };

            //setup address
            var address = new Address()
            {
                StreetNumber = model.StreetNumber,
                StreetName = model.StreetName,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
                UnitNumber = model.UnitNumber != null ? model.UnitNumber : string.Empty,
                PONumber = model.PONumber != null ? model.PONumber : string.Empty,
                Residential = model.PONumber != null ? true : false
            };
            
            user.UserAddress = address;

            //TODO: do something with the data (send to database)
            using(var db = new DatabaseContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            //redirect to Home page
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        [AutoValidateAntiforgeryTokenAttribute]
        public IActionResult LoginPost(UserLoginModel model)
        {
            var user = new UserLoginModel();

            user.UserName = model.UserName;
            user.Password = model.Password;

            //to something with the data (can the user be loggedin)

            //for now
            if(user.Password == user.UserName)
            {
                return RedirectToAction("Index", "Home"); // this has to change later on
            }
            else
            {
                ViewBag.message = "Login Attempt Failed!";
                return View(); // this has to change later on
            }

            
        }


    }
}