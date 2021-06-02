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
    public class IndexModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public IndexModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Место> Место { get;set; }

        public async Task OnGetAsync()
        {
            Место = await _context.Места
                .Include(м => м.КодСеансаNavigation).ToListAsync();
        }
    }
}
