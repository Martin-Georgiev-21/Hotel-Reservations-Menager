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
        private readonly ApplicationDbContext _context;

        public RoomsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Rooms
        public IActionResult Index(string sortOrder, string searchString, int pg = 1)
        {

            int? userId = HttpContext.Session.GetInt32("UserId");
            if (userId != null)
            {
                ViewBag.UserId = userId;
            }


            var rooms = _context.Rooms.AsQueryable();

                // Filter the data based on the search string
                if (!string.IsNullOrEmpty(searchString))
                {
                    rooms = rooms.Where(r => r.Type.Contains(searchString));
                }

                const int pageSize = 10;
                if (pg < 1) pg = 1;
                int rescCount = rooms.Count();
                var pager = new Pager(rescCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;

                // Sort the filtered data based on the sort order
                switch (sortOrder)
                {
                    case "name_desc":
                        rooms = rooms.OrderByDescending(r => r.Type);
                        break;
                    case "capacity":
                        rooms = rooms.OrderBy(r => r.Capacity);
                        break;
                    case "capacity_desc":
                        rooms = rooms.OrderByDescending(r => r.Capacity);
                        break;
                    default:
                        rooms = rooms.OrderBy(r => r.Type);
                        break;
                }

                // Paginate the sorted data
                var data = rooms.Skip(recSkip).Take(pager.PageSize).ToList();
                this.ViewBag.Pager = pager;

                ViewData["NameSortParam"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
                ViewData["CapacitySortParam"] = sortOrder == "capacity" ? "capacity_desc" : "capacity";
                ViewData["CurrentFilter"] = searchString;


                return View(data);
            
            
        }



        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rooms == null)
            {
                return NotFound();
            }

            return View(rooms);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rooms/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Capacity,Type,IsAvailable,PricePerAdult,PricePerChild,Number")] Rooms rooms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rooms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rooms);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms.FindAsync(id);
            if (rooms == null)
            {
                return NotFound();
            }
            return View(rooms);
        }

        // POST: Rooms/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Capacity,Type,IsAvailable,PricePerAdult,PricePerChild,Number")] Rooms rooms)
        {
            if (id != rooms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rooms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomsExists(rooms.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rooms);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rooms == null)
            {
                return NotFound();
            }

            return View(rooms);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rooms = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(rooms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomsExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }
    }
}
