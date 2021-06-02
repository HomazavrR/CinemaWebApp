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
    public class TicketsModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public TicketsModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Место> Место { get; set; }
        public IList<Репертуар> Репертуар { get; set; }
        public IList<Сотрудник> Сотрудник { get; set; }
        public async Task OnGetAsync()
        {
            Место = await _context.Места.ToListAsync();
            Репертуар = await _context.Репертуары.ToListAsync();
            Сотрудник = await _context.Сотрудники.ToListAsync();
        }
    }
}
