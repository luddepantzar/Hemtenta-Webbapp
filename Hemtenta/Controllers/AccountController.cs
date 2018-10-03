using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hemtenta.Data;
using Hemtenta.Models;
using Hemtenta.RequestObj;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hemtenta.Controllers
{
    public class AccountController : Controller
    {
        private DataBaseContext db;
        private UserManager<AppUser> usermanager;
        private SignInManager<AppUser> signinmanager;

        public AccountController(DataBaseContext db, UserManager<AppUser> usermanager, SignInManager<AppUser> signinmanager)
        {
            this.db = db;
            this.usermanager = usermanager;
            this.signinmanager = signinmanager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginRequestObj request)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await signinmanager.PasswordSignInAsync(request.UserName, request.Password, false, false);

            if (!result.Succeeded)
            {
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestObj request)
        {
            if (!ModelState.IsValid || request.Password != request.ConfirmPassword)
            {
                return View();
            }

            AppUser user = new AppUser
            {
                Email = request.Email,
                UserName = request.UserName
            };

            IdentityResult result = await usermanager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                ViewData["Errors"] = result.Errors;
                return View();
            }
            return RedirectToAction("LogIn");
        }
    }
}