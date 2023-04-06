using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation_Menager.Data;
using Hotel_Reservation_Menager.Models;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Hotel_Reservation_Menager;

namespace Hotel_Reservation_Manager.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ReservationsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            IEnumerable<Reservations> objList = _db.Reservations;
            return View(objList);
        }

        public IActionResult CreateReservation()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReservation(Reservations obj)
        {
            //var obj = _db.ToDoLists.Find(id);
            obj.UserId = Logged.LoggedId;
            _db.Reservations.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _db.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            
                return View();
            
        }


        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomId,Accommodation,Exemption,IsBreakfast,IsAllInclusive,Price,StartDate,EndDate")] Reservations reservation)
        {
            if (ModelState.IsValid)
            {
                int? userId = HttpContext.Session.GetInt32("UserId");

                // Set the user ID on the reservation
                reservation.UserId = (int)userId;

                // Check if the room exists
                var roomExists = await _db.Rooms.AnyAsync(r => r.Id == reservation.RoomId);
                if (!roomExists)
                {
                    ModelState.AddModelError("RoomId", "The room does not exist.");
                    return View(reservation);
                }

                // Check if the end date is greater than the start date
                if (reservation.Accommodation.CompareTo(reservation.Exemption) >= 0)
                {
                    ModelState.AddModelError("Accommodation", "The end date value must be before the start value.");
                    return View(reservation);
                }

                // Save the reservation
                _db.Add(reservation);
                await _db.SaveChangesAsync();

                // Create a user reservation record for the logged-in user
                var userReservation = new UserReservation
                {
                    UserId = (int)userId,
                    ReservationId = reservation.Id
                };
                _db.Add(userReservation);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(reservation);
        }




        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _db.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }


        // POST: Reservations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoomId,UserId,Accommodation,Exemption,IsBreakfast,IsAllInclusive,Price")] Reservations reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(reservation);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
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
            return View(reservation);
        }

        // POST: Reservations/AddClientToReservation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClientToReservation(int reservationId, int clientId)
        {
            // Find the reservation and client by their IDs
            var reservation = await _db.Reservations.FindAsync(reservationId);
            var client = await _db.Clients.FindAsync(clientId);

            if (reservation == null || client == null)
            {
                
                return NotFound();
            }

           
            var reservationClient = new ReservationClient
            {
                Reservation = reservation,
                Client = client
            };


            _db.ReservationClient.Add(reservationClient);
            await _db.SaveChangesAsync();

        
            return Ok();
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _db.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _db.Reservations.FindAsync(id);
            _db.Reservations.Remove(reservation);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _db.Reservations.Any(e => e.Id == id);
        }
    }
}


