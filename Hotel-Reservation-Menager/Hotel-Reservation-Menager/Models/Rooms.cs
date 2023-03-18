﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace Hotel_Reservation_Menager.Models

{
    public class Rooms
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required]
        
        public bool IsAvailable { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal PricePerAdult { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal PricePerChild { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
