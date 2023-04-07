using Hotel_Reservation_Menager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager
{
    static public class Logged
    {
        private static bool loggedIn = false;
        private static int loggedId;
        private static Reservations currentReservation;
        private static List<ReservationClient> reservationClient;
        public static bool LoggedIn { get => loggedIn; set => loggedIn = value; }
        public static int LoggedId { get => loggedId; set => loggedId = value; }

        public static Reservations CurrentReservation { get => currentReservation; set => currentReservation = value; }
        public static List<ReservationClient> ReservationClient { get => reservationClient; set => reservationClient = value; }
    }
}
