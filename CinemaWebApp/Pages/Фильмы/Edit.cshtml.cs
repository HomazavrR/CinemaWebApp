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

namespace CinemaWebApp.Pages.Фильмы
{
    public class EditModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public EditModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Фильм Фильм { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Фильм = await _context.Фильмы
                .Include(ф => ф.КодЖанраNavigation).FirstOrDefaultAsync(m => m.КодФильма == id);

            if (Фильм == null)
            {
                return NotFound();
            }
           ViewData["КодЖанра"] = new SelectList(_context.Жанры, "КодЖанра", "Наименование");
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

            _context.Attach(Фильм).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ФильмExists(Фильм.КодФильма))
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

        private bool ФильмExists(long id)
        {
            return _context.Фильмы.Any(e => e.КодФильма == id);
        }
    }
}
