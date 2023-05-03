	using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class EventController : Controller
    {
        private static List<Event> Events = new List<Event>()
        {
            new Event { Id = 0, Name="Event1", Location="Bitola"}
        };
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowEvent(int id)
        {
            var model = Events.ElementAt(id);
            model.Id = id;
            return View(model);
        }
        public ActionResult ShowAllEvents()
        {
            return View(Events);
        }
        public ActionResult NewEvent()
        {
            Event model = new Event();
            model.Id=Events.Max(x=> x.Id)+1;
            return View(model);
        }
        [HttpPost]
        public ActionResult NewEvent(Event model)
        {
            if (ModelState.IsValid == false)
            {
                return View("NewEvent", model);
            }
            Events.Add(model);
            return View("ShowAllEvents", Events);
        }
        public ActionResult EditEvent(int id)
        {
            var model = Events.ElementAt(id);
            model.Id= id;
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEvent(Event model)
        {
            if (ModelState.IsValid == false)
            {
                return View("ShowAllEvents", Events);
            }
            var forEdit = Events.ElementAt(model.Id);
            forEdit.Name = model.Name;
            forEdit.Location = model.Location;
            forEdit.Id=model.Id;
            return View("ShowAllEvents", Events);
        }
        public ActionResult DeleteEvent(int id)
        {
            if (Events.Count()>=id)
                Events.RemoveAt(id);
            return View("ShowAllEvents", Events);
        }
    }
}