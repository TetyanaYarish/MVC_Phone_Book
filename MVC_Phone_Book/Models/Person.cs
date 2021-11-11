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

        //  private string _firstName;
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        //{
        //    get
        //    {
        //        return _firstName;
        //    }
        //    set
        //    {
        //        if (value != "Bob")
        //            throw new ArgumentException("Only Bobs are allowed here!");
        //        _firstName = value;
        //    }
        //}
        [Display(Name = "Email")]
        // [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Second Name")]

        public string SecondName { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(10)]
        public int PhoneNumber { get; set; }
    }
}
