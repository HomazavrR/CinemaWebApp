using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Места
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DeleteModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Место Место { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Место = await _context.Места
                .Include(м => м.КодСеансаNavigation).FirstOrDefaultAsync(m => m.НомерМеста == id);

            if (Место == null)
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

            Место = await _context.Места.FindAsync(id);

            if (Место != null)
            {
                _context.Места.Remove(Место);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
