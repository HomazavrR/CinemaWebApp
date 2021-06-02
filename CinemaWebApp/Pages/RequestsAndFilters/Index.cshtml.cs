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
        public List<SelectListItem> ��������� { get; set; }
        public List<SelectListItem> ���� { get; set; }
        public List<SelectListItem> ��������� { get; set; }
       /* public List<SelectListItem> Mark { get; set; }
        public List<SelectListItem> Data { get; set; }*/

        public IActionResult OnGet()
        {
            ��������� = _context.���������.Select(p =>
                new SelectListItem
                {
                    Value = p.������������.ToString(),
                    Text = p.���������������������
                }).ToList();

           ���� = _context.�����.Select(p =>
               new SelectListItem
               {
                   Value = p.��������.ToString(),
                   Text = p.������������
               }).ToList();

            ��������� = _context.����������.Select(p =>
              new SelectListItem
              {
                  Value = p.����.ToString(),
                  Text = p.����.ToString()
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
