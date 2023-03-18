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
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "EGN must be exactly 10 digits.")]
        [DisplayName("EGN")]
        public string Egn { get; set; }

        [Required]
        [RegularExpression("^\\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
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
        [DateGreaterThan("HireDate", ErrorMessage = "Termination date must be greater than hire date.")]
        [DisplayName("Termination Date")]
        public DateTime? TerminationDate { get; set; }



        public class DateGreaterThanAttribute : ValidationAttribute
            {
                private readonly string _comparisonProperty;

                public DateGreaterThanAttribute(string comparisonProperty)
                {
                    _comparisonProperty = comparisonProperty;
                }

                protected override ValidationResult IsValid(object value, ValidationContext validationContext)
                {
                    var propertyInfo = validationContext.ObjectType.GetProperty(_comparisonProperty);
                    if (propertyInfo == null)
                    {
                        return new ValidationResult($"Property {_comparisonProperty} not found.");
                    }

                    var comparisonValue = propertyInfo.GetValue(validationContext.ObjectInstance) as DateTime?;

                    if (value == null || comparisonValue == null)
                    {
                        return ValidationResult.Success;
                    }

                    if (comparisonValue >= (DateTime)value)
                    {
                        return new ValidationResult(ErrorMessage);
                    }

                    return ValidationResult.Success;
                }
            }
        }

    }

