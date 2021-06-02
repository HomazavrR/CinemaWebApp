using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using CinemaWebApp.Data;
using CinemaWebApp.Models;

namespace CinemaWebApp.Pages.RequestsAndFilters.Reqests
{
    public class HumanResourceModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public HumanResourceModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<���������> ���������� { get; set; }
        public IList<���������> ��������� { get; set; }
        public async Task OnGetAsync()
        {
            ���������� = await _context.����������.ToListAsync();
            ��������� = await _context.���������.ToListAsync();
        }
    }
}
