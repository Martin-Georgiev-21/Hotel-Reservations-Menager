using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Models
{
    public class BigView
    {
        public BigView(IEnumerable<Reservations> reservations, IEnumerable<ReservationClient> reservationClient, IEnumerable<Clients> clients)
        {
            this.reservations = reservations;
            this.reservationClient = reservationClient;
            this.clients = clients;
        }

        private IEnumerable<Reservations> reservations;
        private IEnumerable<ReservationClient> reservationClient;
        private IEnumerable<Clients> clients;

        public IEnumerable<Reservations> Reservations
        {
            get => reservations;
            set => reservations = value;
        }
        public IEnumerable<ReservationClient> ReservationClient
        {
            get => reservationClient;
            set => reservationClient = value;
        }
        public IEnumerable<Clients> Clients
        {
            get => clients;
            set => clients = value;
        }
    }
}
