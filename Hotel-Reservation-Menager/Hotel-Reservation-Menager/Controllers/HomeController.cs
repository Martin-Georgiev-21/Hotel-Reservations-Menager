using Hotel_Reservation_Menager.Data;
using Hotel_Reservation_Menager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogIn(Users obj)
        {
            var activeUser = _db.Users.SingleOrDefault(u => u.Username == obj.Username && u.Password == obj.Password && (u.TerminationDate == null || u.TerminationDate > DateTime.Today));

            if (activeUser != null)
            {

                if (activeUser.UserId == 1)
                {
                    Logged.LoggedIn = true;
                    Logged.LoggedId = activeUser.UserId;
                    return View("../AfterLogInAdmin");
                }
                else
                {
                    Logged.LoggedIn = true;
                    Logged.LoggedId = activeUser.UserId;
                    return View("../AfterLogInNoAdmin");
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password, or user is inactive.";
                return View("Index");
            }
        }

        public IActionResult Back()
        {
            if (Logged.LoggedId == 1)
            {
                return View("../AfterLogInAdmin");
            }
            else return View("../AfterLogInNoAdmin");
        }


        public IActionResult LogOut()
        {
            Logged.LoggedIn = false;
            Logged.LoggedId = default;
            HttpContext.Session.Remove("UserId");
            ModelState.Clear();
            return View("Index");
        }


        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
