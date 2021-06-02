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

namespace CinemaWebApp.Pages.Места
{
    public class EditModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public EditModel(CinemaWebApp.Data.CinemaContext context)
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
           ViewData["КодСеанса"] = new SelectList(_context.Репертуары, "КодСеанса", "КодСеанса");
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

            _context.Attach(Место).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!МестоExists(Место.НомерМеста))
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

        private bool МестоExists(long id)
        {
            return _context.Места.Any(e => e.НомерМеста == id);
        }
    }
}
