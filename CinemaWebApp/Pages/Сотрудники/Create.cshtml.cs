using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Сотрудники
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
        ViewData["КодДолжности"] = new SelectList(_context.Должности, "КодДолжности", "НаименованиеДолжности");
            return Page();
        }

        [BindProperty]
        public Сотрудник Сотрудник { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Сотрудники.Add(Сотрудник);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
