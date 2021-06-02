using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc.Rendering;


namespace CinemaWebApp.Pages.RequestsAndFilters
{
    public class IndexModel : PageModel
    {
        private readonly CinemaWebApp.Data.CinemaContext _context;

        public IndexModel(CinemaWebApp.Data.CinemaContext context)
        {
            _context = context;
        }
        public List<SelectListItem> Должность { get; set; }
        public List<SelectListItem> Жанр { get; set; }
        public List<SelectListItem> Репертуар { get; set; }
       /* public List<SelectListItem> Mark { get; set; }
        public List<SelectListItem> Data { get; set; }*/

        public IActionResult OnGet()
        {
            Должность = _context.Должности.Select(p =>
                new SelectListItem
                {
                    Value = p.КодДолжности.ToString(),
                    Text = p.НаименованиеДолжности
                }).ToList();

           Жанр = _context.Жанры.Select(p =>
               new SelectListItem
               {
                   Value = p.КодЖанра.ToString(),
                   Text = p.Наименование
               }).ToList();

            Репертуар = _context.Репертуары.Select(p =>
              new SelectListItem
              {
                  Value = p.Дата.ToString(),
                  Text = p.Дата.ToString()
              }).ToList();

            /*Type = _context.TypeOfPolicy.Select(p =>
               new SelectListItem
               {
                   Value = p.TypeOfPolicyId.ToString(),
                   Text = p.Name
               }).ToList();

            Mark = _context.Policy.Select(p =>
               new SelectListItem
               {
                   Value = p.PaymentMark.ToString(),
                   Text = p.PaymentMark
               }).ToList();

            Data = _context.Policy.Select(p =>
              new SelectListItem
              {
                  Value = p.MarkOfEnd.ToString(),
                  Text = p.MarkOfEnd
              }).ToList();*/

            return Page();
        }
    }
}
