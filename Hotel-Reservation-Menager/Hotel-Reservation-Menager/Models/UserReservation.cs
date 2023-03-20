using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Reservation_Menager.Models
{
    public class UserReservation
    {
       
        public int Id { get; set; }

        [ForeignKey("Reservations")]
        public int ReservationId { get; set; }
        public Reservations Reservations { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
