using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Фильмы
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DeleteModel(CinemaWebApp.Data.CinemaContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Фильм = await _context.Фильмы.FindAsync(id);

            if (Фильм != null)
            {
                _context.Фильмы.Remove(Фильм);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
