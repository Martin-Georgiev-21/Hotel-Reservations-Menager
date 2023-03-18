using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Models
{
    public class Reservations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        [Required]
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public List<Clients> ListOfClients { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string Accommodation { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string Exemption { get; set; }
        [Required]
        public bool IsBreakfast { get; set; }
        [Required]
        public bool IsAllInclusive { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


    }
}
