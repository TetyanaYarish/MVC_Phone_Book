using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Phone_Book.Models;

namespace MVC_Phone_Book.Data
{
    public class MVC_Phone_BookContext : DbContext
    {
        public MVC_Phone_BookContext (DbContextOptions<MVC_Phone_BookContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Phone_Book.Models.Person> Person { get; set; }
    }
}
