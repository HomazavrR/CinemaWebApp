using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.RequestsAndFilters.Filters
{
    public class SessionDateFilterModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public SessionDateFilterModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<�����> ����� { get; set; }
        public ��������� ��������� { get; set; }
        public async Task<IActionResult> OnGetAsync(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ��������� = _context.����������.First(m => m.���� == id);

            if (��������� == null)
            {
                return NotFound();
            }
            ����� = await _context.�����
                 .Include(e => e.���������Navigation).Where(m => m.���������Navigation.���� == ���������.����).ToListAsync();
            return Page();
        }
    }
}
