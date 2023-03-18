namespace Hotel_Reservation_Menager.Models
{
        public class ReservationClient
        {
            public int Id { get; set; }
            public int ReservationId { get; set; }
            public Reservations Reservation { get; set; }
            public int ClientId { get; set; }
            public Clients Client { get; set; }
        }

    }


