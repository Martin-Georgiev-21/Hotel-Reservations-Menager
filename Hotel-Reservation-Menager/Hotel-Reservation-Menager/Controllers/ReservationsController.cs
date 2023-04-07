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
using System;

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
            IEnumerable<Reservations> reservations = _db.Reservations;
            IEnumerable<ReservationClient> reservationClients = _db.ReservationClient;
            IEnumerable<Clients> clients = _db.Clients;
            BigView bigview = new BigView(reservations, reservationClients, clients);
            foreach (var reservation in reservations)
            {
                Rooms chosenRoom = new Rooms();
                foreach (var room in _db.Rooms)
                {
                    if (room.Number == reservation.RoomId) 
                    { 
                        chosenRoom = room;
                        if (DateTime.Parse(reservation.Exemption) < DateTime.Today || DateTime.Parse(reservation.Accommodation) > DateTime.Today)
                        {
                            chosenRoom.IsAvailable = true;
                        }
                        else chosenRoom.IsAvailable = false;
                    }
                }
            }
            _db.SaveChanges();
            return View(bigview);
        }

        public IActionResult CreateReservation()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReservation(Reservations obj)
        {
            obj.UserId = Logged.LoggedId;
            Rooms chosenRoom = new Rooms();
            foreach (var room in _db.Rooms)
            {
                if (room.Number == obj.RoomId) chosenRoom = room;
            }
            if (chosenRoom == null || obj.Accommodation == null || obj.Exemption == null || (DateTime.Parse(obj.Accommodation) > DateTime.Parse(obj.Exemption)) || chosenRoom.IsAvailable == false)
            {
                return RedirectToAction("CreateReservation");
            }
            else if (DateTime.Parse(obj.Exemption) < DateTime.Today || DateTime.Parse(obj.Accommodation) > DateTime.Today)
            {
                chosenRoom.IsAvailable = true;
            }
            else
            {
                chosenRoom.IsAvailable = false;
            }
            _db.Reservations.Add(obj);
            _db.Rooms.Update(chosenRoom);
            _db.SaveChanges();
            foreach (var element in _db.Reservations)
            {
                if (element.RoomId == obj.RoomId && DateTime.Parse(element.Accommodation) == DateTime.Parse(obj.Accommodation) && DateTime.Parse(element.Exemption) == DateTime.Parse(obj.Exemption))
                {
                    Logged.CurrentReservation = element;
                }
            }
            return RedirectToAction("ChooseClients");
        }
        public IActionResult ChooseClients(string sortOrder, string searchString, int clicked = 0, int page = 1, int pageSize = 6)
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

            Logged.ReservationClient = _db.ReservationClient.ToList();

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

        public IActionResult AddClient(int? id)
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
            return AddClient(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddClient(Clients obj)
        {
            ReservationClient reservationClient = new ReservationClient();
            reservationClient.ClientId = obj.Id;
            reservationClient.ReservationId = Logged.CurrentReservation.Id;
            Rooms chosenRoom = new Rooms();
            foreach (var room in _db.Rooms)
            {   
                if (room.Number == Logged.CurrentReservation.RoomId) chosenRoom = room;
            }
            if (obj.IsAdult == true) Logged.CurrentReservation.Price += chosenRoom.PricePerAdult;
            else Logged.CurrentReservation.Price += chosenRoom.PricePerChild;
            _db.Reservations.Update(Logged.CurrentReservation);
            _db.ReservationClient.Add(reservationClient);
            _db.SaveChanges();
            return RedirectToAction("ChooseClients");
        }
        public IActionResult RemoveClient(int? id)
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
            return RemoveClient(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveClient(Clients obj)
        {
            ReservationClient reservationClient = new ReservationClient();
            reservationClient.ClientId = obj.Id;
            reservationClient.ReservationId = Logged.CurrentReservation.Id;
            Rooms chosenRoom = new Rooms();
            foreach (var room in _db.Rooms)
            {
                if (room.Number == Logged.CurrentReservation.RoomId) chosenRoom = room;
            }
            if (obj.IsAdult == true) Logged.CurrentReservation.Price -= chosenRoom.PricePerAdult;
            else Logged.CurrentReservation.Price -= chosenRoom.PricePerChild;
            foreach (var element in _db.ReservationClient)
            {
                if (element.ClientId == reservationClient.ClientId && element.ReservationId == Logged.CurrentReservation.Id) reservationClient = element;
            }
            _db.Reservations.Update(Logged.CurrentReservation);
            _db.ReservationClient.Remove(reservationClient);
            _db.SaveChanges();
            return RedirectToAction("ChooseClients");
        }
        public IActionResult Done()
        {
            if (Logged.CurrentReservation.IsAllInclusive == true) Logged.CurrentReservation.Price += Logged.CurrentReservation.Price * 10 / 100;
            if (Logged.CurrentReservation.IsBreakfast == true) Logged.CurrentReservation.Price += Logged.CurrentReservation.Price * 5 / 100;
            if (Logged.CurrentReservation.IsAllInclusive == true && Logged.CurrentReservation.IsBreakfast) Logged.CurrentReservation.Price += Logged.CurrentReservation.Price * 10 / 100;
            _db.Reservations.Update(Logged.CurrentReservation);
            _db.SaveChanges();
            return RedirectToAction("Index");
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


