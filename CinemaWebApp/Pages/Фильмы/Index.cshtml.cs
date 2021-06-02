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
    public class IndexModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public IndexModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Фильм> Фильм { get;set; }

        public async Task OnGetAsync()
        {
            Фильм = await _context.Фильмы
                .Include(ф => ф.КодЖанраNavigation).ToListAsync();
        }
    }
}
