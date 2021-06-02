using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Сотрудники
{
    public class DetailsModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DetailsModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public Сотрудник Сотрудник { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Сотрудник = await _context.Сотрудники
                .Include(с => с.КодДолжностиNavigation).FirstOrDefaultAsync(m => m.КодСотрудника == id);

            if (Сотрудник == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
