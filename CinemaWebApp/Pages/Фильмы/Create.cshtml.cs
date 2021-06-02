using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Фильмы
{
    public class CreateModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public CreateModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["КодЖанра"] = new SelectList(_context.Жанры, "КодЖанра", "Наименование");
            return Page();
        }

        [BindProperty]
        public Фильм Фильм { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Фильмы.Add(Фильм);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
