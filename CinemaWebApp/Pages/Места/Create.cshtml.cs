using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Места
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
        ViewData["КодСеанса"] = new SelectList(_context.Репертуары, "КодСеанса", "КодСеанса");
            return Page();
        }

        [BindProperty]
        public Место Место { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Места.Add(Место);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
