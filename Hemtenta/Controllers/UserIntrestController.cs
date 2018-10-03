using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hemtenta.Data;
using Hemtenta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hemtenta.Controllers
{
    public class UserIntrestController : Controller
    {
        private DataBaseContext db;

        public UserIntrestController(DataBaseContext db)
        {
            this.db = db;
        }

        [Authorize, HttpPost]
        public IActionResult Create(UserIntrest userintrests)
        {
            var loggedUser = User.Identity;

            var user = new UserIntrest();
            user.EventId = userintrests.EventId;
            user.UserName = loggedUser.Name;

            db.UserIntrests.Add(user);
            db.SaveChanges();

            return RedirectToAction("Details", "Event", new { id = userintrests.EventId });
            //return RedirectToAction("Index", "Event");
        }
    }
}