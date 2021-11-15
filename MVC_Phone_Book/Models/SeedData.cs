using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_Phone_Book.Data;
using System;
using System.Linq;

namespace MVC_Phone_Book.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)// IServiceProvider using System;
        {
            using (var context = new MVC_Phone_BookContext(serviceProvider.GetRequiredService<DbContextOptions<MVC_Phone_BookContext>>())) //GetRequiredService - using Microsoft.Extensions.DependencyInjection;
                                                                                                                                           //DbContextOptions -using Microsoft.EntityFrameworkCore;

            {
                if(context.Person.Any()) //Any -using System.Linq; //If we have none contacts the seed initializer returns and no contact are added.
                { 
                    return;
                }
                context.Person.AddRange(
                    new Person
                    {
                        FirstName = "Bob",
                        SecondName = "Brisbane",
                        Address = "Her new home",
                        DateOfBirth = DateTime.Parse("2000-2-12"),
                        PhoneNumber = "0123456789",
                        Age = 35,

                    },
                     new Person
                     {
                         FirstName = "Bob",
                         SecondName = "Tramp",
                         Address = "Her new home",
                         DateOfBirth = DateTime.Parse("2000-2-12"),
                         PhoneNumber = "0123456789",
                         Age =35,                    
                     }
                    );
                context.SaveChanges();
            }

         }
    }
}
