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
    public class HRFilterModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public HRFilterModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Сотрудник> Сотрудник { get; set; }
        public Должность Должность { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Должность = _context.Должности.First(m => m.КодДолжности == id);

            if (Должность == null)
            {
                return NotFound();
            }
            Сотрудник = await _context.Сотрудники
                .Include(e => e.КодДолжностиNavigation).Where(m => m.КодДолжности == Должность.КодДолжности).ToListAsync();
            return Page();
        }
    }
}
