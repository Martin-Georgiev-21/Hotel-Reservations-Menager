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
        public IActionResult Index(string sortOrder, string searchString, int pg = 1)
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

            if (pg < 1) pg = 1;
            const int pageSize = 10;
            int rescCount = clients.Count();
            var pager = new Pager(rescCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;

            // Sort the filtered data based on the sort order
            switch (sortOrder)
            {
                case "name_desc":
                    clients = clients.OrderByDescending(c => c.LastName);
                    break;
                case "first_name":
                    clients = clients.OrderBy(c => c.FirstName);
                    break;
                case "first_name_desc":
                    clients = clients.OrderByDescending(c => c.FirstName);
                    break;
                default:
                    clients = clients.OrderBy(c => c.LastName);
                    break;
            }

            // Project the sorted data into a new list of Clients objects
            var data = clients
                .Skip(recSkip)
                .Take(pager.PageSize)
                .Select(c => new Clients
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email
                })
                .ToList();

            this.ViewBag.Pager = pager;

            ViewData["NameSortParam"] = sortOrder == "name_desc" ? "" : "name_desc";
            ViewData["FirstNameSortParam"] = sortOrder == "first_name" ? "first_name_desc" : "first_name";
            ViewData["CurrentFilter"] = searchString;

            return View(data);
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
