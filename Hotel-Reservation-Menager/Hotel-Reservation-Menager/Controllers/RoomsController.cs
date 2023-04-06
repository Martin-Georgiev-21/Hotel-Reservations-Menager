using Hotel_Reservation_Menager.Data;
using Hotel_Reservation_Menager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

namespace Hotel_Reservation_Menager.Controllers
{
    public class RoomsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public RoomsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Rooms
        public IActionResult Index(string sortOrder, int clicked = 0, int page = 1, int pageSize = 6)
        {
            var rooms = from s in _db.Rooms
                        select s;

            var totalCount = rooms.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var currentclicked = clicked;

            switch (sortOrder, clicked)
            {
                case ("Capacity", 1):
                    rooms = rooms.OrderBy(s => s.Capacity);
                    clicked = 0;
                    break;
                case ("Capacity", 0):
                    rooms = rooms.OrderByDescending(s => s.Capacity);
                    clicked = 1;
                    break;
                case ("Type", 1):
                    rooms = rooms.OrderBy(s => s.Type);
                    clicked = 0;
                    break;
                case ("Type", 0):
                    rooms = rooms.OrderByDescending(s => s.Type);
                    clicked = 1;
                    break;
                case ("IsAvailable", 1):
                    rooms = rooms.OrderBy(s => s.IsAvailable);
                    clicked = 0;
                    break;
                case ("IsAvailable", 0):
                    rooms = rooms.OrderByDescending(s => s.IsAvailable);
                    clicked = 1;
                    break;
                default:
                    rooms = rooms.OrderBy(s => s.Id);
                    break;
            }

            var pageData = rooms.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalCount = totalCount;
            ViewBag.TotalPages = totalPages;
            ViewBag.Clicked = clicked;
            ViewBag.CurrentClicked = currentclicked;
            ViewBag.SortOrder = sortOrder;

            return View(pageData);
        }

        // GET: Rooms/Create
        public IActionResult CreateRoom()
        {
            return View();
        }

        // POST: Rooms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRoom(Rooms obj)
        {
            obj.IsAvailable = true;
            _db.Rooms.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Rooms/Edit/5
        public IActionResult EditRoom(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Rooms.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: Rooms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRoom(Rooms obj)
        {
            _db.Rooms.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRoom(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Rooms.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRoom(Rooms obj)
        {
            _db.Rooms.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
