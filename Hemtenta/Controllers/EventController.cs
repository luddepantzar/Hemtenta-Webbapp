﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hemtenta.Data;
using Hemtenta.Models;
using Hemtenta.RequestObj;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hemtenta.Controllers
{
    public class EventController : Controller
    {
        private DataBaseContext db;

        public EventController(DataBaseContext db)
        {
            this.db = db;
        }

        public IActionResult Index(FilterRequestObj request)
        {
            request.Filter = request.Filter?.ToLower() ?? "";

            List<Event> model = db.Events
                .Where(m => m.Title.ToLower().Contains(request.Filter))
                .ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Event model = db.Events
                .Where(m => m.Id == id)
                .Include(m => m.UserIntrests)
                .FirstOrDefault();

            return View(model);
        }
        
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Authorize]
        public IActionResult Create(Event events)
        {
            var loggedUser = User.Identity;

            var user = new UserIntrest();
            user.EventId = events.Id;
            user.UserName = loggedUser.Name;
            user.Owner = true;

            var list = new List<UserIntrest>();
            list.Add(user);

            events.UserIntrests = list;

            db.Events.Add(events);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}