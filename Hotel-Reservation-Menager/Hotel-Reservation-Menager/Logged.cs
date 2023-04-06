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
        public static bool LoggedIn { get => loggedIn; set => loggedIn = value; }
        public static int LoggedId { get => loggedId; set => loggedId = value; }
    }
}
