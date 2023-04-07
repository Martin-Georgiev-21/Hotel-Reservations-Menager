using Hotel_Reservation_Manager.Controllers;
using Hotel_Reservation_Menager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager
{
    public class Helper
    {
        public static bool IsAdded(int id)
        {
            foreach (var element in Logged.ReservationClient)
            {
                if (element.ClientId == id && element.ReservationId == Logged.CurrentReservation.Id) return true;
            }
            return false;
        }
    }
}
