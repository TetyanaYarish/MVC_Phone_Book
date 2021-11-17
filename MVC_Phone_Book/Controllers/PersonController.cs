using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Phone_Book.Data;
using MVC_Phone_Book.Models;
using Newtonsoft.Json;

namespace MVC_Phone_Book.Controllers
{
    public class PersonController : Controller
    {
        private readonly MVC_Phone_BookContext _context;

        public PersonController(MVC_Phone_BookContext context)
        {
            _context = context;
        }

        //GET: PersonClasses
        //[HttpGet]
        public async Task<IActionResult> Index(string searchString)
        {
            var people = from p in _context.Person
                         select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                people = people.Where(p => p.FirstName.Contains(searchString));
            }
            return View(await people.ToListAsync());
        }

        //GET: PersonClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personClass = await _context.Person
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personClass == null)
            {
                return NotFound();
            }

            return View(personClass);
        }
        public async Task<IActionResult> AverageAge([FromQuery] string firstName)
        {

            if (firstName == null)
            {
                return NotFound();
            }

            var personClass = from p in _context.Person select p;

            if (!String.IsNullOrEmpty(firstName))
            {
                personClass = personClass.Where(p => p.FirstName.Contains(firstName));
            }

            return View(await personClass.ToListAsync());
        }

        // POST: PersonClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,SecondName,DateOfBirth,Address,PhoneNumber,Email")] Person personClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personClass);
        }

        // GET: PersonClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personClass = await _context.Person.FindAsync(id);
            if (personClass == null)
            {
                return NotFound();
            }
            return View(personClass);
        }

        // POST: PersonClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,SecondName,DateOfBirth,Address,PhoneNumber,Email")] Person personClass)
        {
            if (id != personClass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonClassExists(personClass.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(personClass);
        }

        // GET: PersonClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personClass = await _context.Person
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personClass == null)
            {
                return NotFound();
            }

            return View(personClass);
        }

        // POST: PersonClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personClass = await _context.Person.FindAsync(id);
            _context.Person.Remove(personClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonClassExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
