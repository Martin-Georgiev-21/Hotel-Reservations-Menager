using Hotel_Reservation_Menager.Data;
using Hotel_Reservation_Menager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClientsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string sortOrder, string searchString, int clicked = 0, int page = 1, int pageSize = 6)
        {
            var clients = _db.Clients.AsQueryable();

            // Filter the data based on the search string
            if (!string.IsNullOrEmpty(searchString))
            {
                clients = clients.Where(c =>
                    c.FirstName.Contains(searchString) ||
                    c.LastName.Contains(searchString) ||
                    c.PhoneNumber.Contains(searchString) ||
                    c.Email.Contains(searchString));
            }

            var totalCount = clients.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var currentclicked = clicked;

            switch (sortOrder, clicked)
            {
                case ("FirstName", 1):
                    clients = clients.OrderBy(s => s.FirstName);
                    clicked = 0;
                    break;
                case ("FirstName", 0):
                    clients = clients.OrderByDescending(s => s.FirstName);
                    clicked = 1;
                    break;
                case ("LastName", 1):
                    clients = clients.OrderBy(s => s.LastName);
                    clicked = 0;
                    break;
                case ("LastName", 0):
                    clients = clients.OrderByDescending(s => s.LastName);
                    clicked = 1;
                    break;
                default:
                    clients = clients.OrderBy(s => s.Id);
                    break;
            }

            var pageData = clients.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalCount = totalCount;
            ViewBag.TotalPages = totalPages;
            ViewBag.Clicked = clicked;
            ViewBag.CurrentClicked = currentclicked;
            ViewBag.SortOrder = sortOrder;
            ViewData["CurrentFilter"] = searchString;

            return View(pageData);
        }





        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateClient(Clients obj)
        {
            _db.Clients.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditClient(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditClient(Clients obj)
        {
            _db.Clients.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteClient(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Clients.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePostClient(Clients obj)
        {
            _db.Clients.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
