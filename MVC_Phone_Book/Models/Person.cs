using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Phone_Book.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int age;
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(60, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Second Name")]

        public string SecondName { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]//Must only use letters.
                                                          //The first letter is required to be uppercase.
                                                          //White spaces are allowed while numbers, and special characters are not allowed.
        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        [MaxLength(10)]

        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Subtract(DateOfBirth).Days / 365;
            }
            set { age = value; }
        }
    }
}
