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
        public IActionResult Index()
        {
            IEnumerable<Clients> objList = _db.Clients;
            return View(objList);
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
