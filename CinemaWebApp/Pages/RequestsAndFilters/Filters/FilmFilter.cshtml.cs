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
    public class FilmFilterModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public FilmFilterModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Фильм> Фильм { get; set; }
        public Жанр Жанр { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Жанр = _context.Жанры.First(m => m.КодЖанра == id);

            if (Жанр == null)
            {
                return NotFound();
            }
           Фильм = await _context.Фильмы
                .Include(e => e.КодЖанраNavigation).Where(m => m.КодЖанра == Жанр.КодЖанра).ToListAsync();
            return Page();
        }
    }
}
