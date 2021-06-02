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
    public class DetailsModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DetailsModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public Должность Должность { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Должность = await _context.Должности.FirstOrDefaultAsync(m => m.КодДолжности == id);

            if (Должность == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
