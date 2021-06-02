using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Сотрудники
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DeleteModel(CinemaWebApp.Data.CinemaContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Сотрудник = await _context.Сотрудники.FindAsync(id);

            if (Сотрудник != null)
            {
                _context.Сотрудники.Remove(Сотрудник);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
