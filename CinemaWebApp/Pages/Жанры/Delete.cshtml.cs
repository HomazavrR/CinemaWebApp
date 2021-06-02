﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.Жанры
{
    public class DeleteModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public DeleteModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Жанр Жанр { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Жанр = await _context.Жанры.FirstOrDefaultAsync(m => m.КодЖанра == id);

            if (Жанр == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Жанр = await _context.Жанры.FindAsync(id);

            if (Жанр != null)
            {
                _context.Жанры.Remove(Жанр);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
