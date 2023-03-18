using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Menager.Models
{
    public class Users
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        [DisplayName("EGN")]
        public string Egn { get; set; }

        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Hire Date")]
        public DateTime HireDate { get; set; }

        [Required]
        [DisplayName("Is Active")]
        public bool IsActive { get; set; } = true;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Termination Date")]
        public DateTime? TerminationDate { get; set; }



       
            }
        }

    

