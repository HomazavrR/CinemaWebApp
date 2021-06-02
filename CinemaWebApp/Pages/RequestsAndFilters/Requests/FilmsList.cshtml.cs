using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.RequestsAndFilters.Requests
{
    public class FilmsListModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public FilmsListModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Фильм> Фильмы { get; set; }
        public IList<Жанр> Жанры { get; set; }
        public async Task OnGetAsync()
        {
            Фильмы = await _context.Фильмы.ToListAsync();
            Жанры = await _context.Жанры.ToListAsync();
        }
    }
}
