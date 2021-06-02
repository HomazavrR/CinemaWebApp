using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Сотрудники
{
    public class EditModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public EditModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Сотрудник Сотрудник { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Сотрудник = await _context.Сотрудники
                .Include(с => с.КодДолжностиNavigation).FirstOrDefaultAsync(m => m.КодСотрудника == id);

            if (Сотрудник == null)
            {
                return NotFound();
            }
           ViewData["КодДолжности"] = new SelectList(_context.Должности, "КодДолжности", "НаименованиеДолжности");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Сотрудник).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!СотрудникExists(Сотрудник.КодСотрудника))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool СотрудникExists(long id)
        {
            return _context.Сотрудники.Any(e => e.КодСотрудника == id);
        }
    }
}
