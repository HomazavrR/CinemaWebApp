using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.RequestsAndFilters.Filters
{
    public class SessionDateFilterModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public SessionDateFilterModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Место> Место { get; set; }
        public Репертуар Репертуар { get; set; }
        public async Task<IActionResult> OnGetAsync(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Репертуар = _context.Репертуары.First(m => m.Дата == id);

            if (Репертуар == null)
            {
                return NotFound();
            }
            Место = await _context.Места
                 .Include(e => e.КодСеансаNavigation).Where(m => m.КодСеансаNavigation.Дата == Репертуар.Дата).ToListAsync();
            return Page();
        }
    }
}
