using System;
using System.Collections.Generic;

namespace MVC_Phone_Book.Models
{
    public interface IContact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set;  }
        public int Age { get; }
       
       
      //  public List<IContact> List { get; set; }
    }
}
