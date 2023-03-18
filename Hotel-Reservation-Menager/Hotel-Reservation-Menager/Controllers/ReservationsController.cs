using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_Reservation_Menager.Data;
using Hotel_Reservation_Menager.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace Hotel_Reservation_Menager.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservations.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public IActionResult Create(int clientId)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == clientId);
            if (client == null)
            {
                return NotFound();
            }

            int userId;
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out userId))
            {
                var reservation = new Reservations
                {
                    UserId = userId,
                    RoomId = 1, // Set the default room ID
                };

                var reservationClient = new ReservationClient
                {
                    Reservation = reservation,
                    Client = client
                };

                _context.ReservationClient.Add(reservationClient);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return NotFound();
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoomId,UserId,Accommodation,Exemption,IsBreakfast,IsAllInclusive,Price")] Reservations reservation)
        {
            if (ModelState.IsValid)
            {
                // Check if the user exists
                var userExists = await _context.Users.AnyAsync(u => u.UserId == reservation.UserId);
                if (!userExists)
                {
                    ModelState.AddModelError("UserId", "The user does not exist.");
                    return View(reservation);
                }

                // Check if the room exists
                var roomExists = await _context.Rooms.AnyAsync(r => r.Id == reservation.RoomId);
                if (!roomExists)
                {
                    ModelState.AddModelError("RoomId", "The room does not exist.");
                    return View(reservation);
                }

                _context.Add(reservation);
                await _context.SaveChangesAsync();
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

            var reservation = await _context.Reservations.FindAsync(id);
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
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
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
            var reservation = await _context.Reservations.FindAsync(reservationId);
            var client = await _context.Clients.FindAsync(clientId);

            if (reservation == null || client == null)
            {
                
                return NotFound();
            }

           
            var reservationClient = new ReservationClient
            {
                Reservation = reservation,
                Client = client
            };

          
            _context.ReservationClient.Add(reservationClient);
            await _context.SaveChangesAsync();

        
            return Ok();
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
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
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}


