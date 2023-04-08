using Hotel_Reservation_Menager.Data;
using Hotel_Reservation_Menager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string sortOrder, string searchString, int clicked = 0, int page = 1, int pageSize = 10)
        {
            var users = from s in _db.Users
                        select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                users = users.Where(c =>
                    c.FirstName.Contains(searchString) ||
                    c.MiddleName.Contains(searchString) ||
                    c.LastName.Contains(searchString) ||
                    c.Username.Contains(searchString));
            }

            var totalCount = users.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var currentclicked = clicked;

            switch (sortOrder, clicked)
            {
                case ("FirstName", 1):
                    users = users.OrderBy(s => s.FirstName);
                    clicked = 0;
                    break;
                case ("FirstName", 0):
                    users = users.OrderByDescending(s => s.FirstName);
                    clicked = 1;
                    break;
                case ("MiddleName", 1):
                    users = users.OrderBy(s => s.MiddleName);
                    clicked = 0;
                    break;
                case ("MiddleName", 0):
                    users = users.OrderByDescending(s => s.MiddleName);
                    clicked = 1;
                    break;
                case ("LastName", 1):
                    users = users.OrderBy(s => s.LastName);
                    clicked = 0;
                    break;
                case ("LastName", 0):
                    users = users.OrderByDescending(s => s.LastName);
                    clicked = 1;
                    break;
                case ("Username", 1):
                    users = users.OrderBy(s => s.Username);
                    clicked = 0;
                    break;
                case ("Username", 0):
                    users = users.OrderByDescending(s => s.Username);
                    clicked = 1;
                    break;
                case ("Email", 1):
                    users = users.OrderBy(s => s.Email);
                    clicked = 0;
                    break;
                case ("Email", 0):
                    users = users.OrderByDescending(s => s.Email);
                    clicked = 1;
                    break;
                default:
                    users = users.OrderBy(s => s.UserId);
                    break;
            }

            var pageData = users.Skip((page - 1) * pageSize).Take(pageSize).ToList();

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
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(Users obj)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditUser(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Users.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUser(Users obj)
        {
            _db.Users.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteUser(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Users.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePostUser(Users obj)
        {
            _db.Users.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
