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
    public class DetailsModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DetailsModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public Место Место { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Место = await _context.Места
                .Include(м => м.КодСеансаNavigation).FirstOrDefaultAsync(m => m.НомерМеста == id);

            if (Место == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
