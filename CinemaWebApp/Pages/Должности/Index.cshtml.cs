using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Должности
{
    public class IndexModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public IndexModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Должность> Должность { get;set; }

        public async Task OnGetAsync()
        {
            Должность = await _context.Должности.ToListAsync();
        }
    }
}
