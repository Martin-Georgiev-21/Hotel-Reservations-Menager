using Hotel_Reservation_Menager.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Rooms> Rooms { get; set; }

        public DbSet<Users> Users { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<ReservationClient> ReservationClient { get; set; }

        public DbSet<UserReservation> UserReservations { get;set; } 


    }

}
