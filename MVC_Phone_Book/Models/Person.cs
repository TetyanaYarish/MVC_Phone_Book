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
        private int age;
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Second Name")]

        public string SecondName { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
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
