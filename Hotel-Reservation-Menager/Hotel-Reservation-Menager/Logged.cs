﻿using Hotel_Reservation_Menager.Models;
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
        private static bool isClicked = false;
        private static Reservations currentReservation;
        private static Clients currentHistory;
        private static List<ReservationClient> reservationClient;
        public static bool LoggedIn { get => loggedIn; set => loggedIn = value; }
        public static int LoggedId { get => loggedId; set => loggedId = value; }

        public static bool IsClicked { get => isClicked; set => isClicked = value; }

        public static Reservations CurrentReservation { get => currentReservation; set => currentReservation = value; }
        public static List<ReservationClient> ReservationClient { get => reservationClient; set => reservationClient = value; }

        public static Clients CurrentHistory { get => currentHistory; set => currentHistory = value; }
    }
}
