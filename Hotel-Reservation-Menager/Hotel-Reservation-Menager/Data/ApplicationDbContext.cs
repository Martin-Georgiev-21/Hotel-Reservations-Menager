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
        public DbSet<ReservationClient> ReservationClients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationClient>()
                .HasKey(rc => new { rc.ReservationId, rc.ClientId });

            modelBuilder.Entity<ReservationClient>()
                .HasOne(rc => rc.Reservation)
                .WithMany(r => r.ListOfClients)
                .HasForeignKey(rc => rc.ReservationId);

            modelBuilder.Entity<ReservationClient>()
                .HasOne(rc => rc.Client)
                .WithMany(c => c.ListOfClients)
                .HasForeignKey(rc => rc.ClientId);

            modelBuilder.Entity<Reservations>()
                .HasMany(r => r.ListOfClients)
                .WithOne(rc => rc.Reservation)
                .HasForeignKey(rc => rc.ReservationId);

            modelBuilder.Entity<Clients>()
                .HasMany(c => c.ListOfClients)
                .WithOne(rc => rc.Client)
                .HasForeignKey(rc => rc.ClientId);
        }
    }

}
