using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Репертуары
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DeleteModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Репертуар Репертуар { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Репертуар = await _context.Репертуары.FirstOrDefaultAsync(m => m.КодСеанса == id);

            if (Репертуар == null)
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

            Репертуар = await _context.Репертуары.FindAsync(id);

            if (Репертуар != null)
            {
                _context.Репертуары.Remove(Репертуар);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
