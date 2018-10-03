using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hemtenta.Data;
using Hemtenta.Models;
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

        public IActionResult Create(UserIntrest userintrest)
        {

            db.UserIntrests.Add(userintrest);
            db.SaveChanges();

            return RedirectToAction("Details", "Event", new { id = userintrest.EventId });
        }
    }
}