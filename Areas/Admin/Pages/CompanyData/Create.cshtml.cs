using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Asp.net5RazorPagesExample.Data;
using Asp.net5RazorPagesExample.Models;

namespace Asp.net5RazorPagesExample.Areas.Admin.Pages.CompanyData
{
    public class CreateModel : PageModel
    {
        private readonly Asp.net5RazorPagesExample.Data.DBContext _context;

        public CreateModel(Asp.net5RazorPagesExample.Data.DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CompanyMainData CompanyMainData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CompanyMainDatas.Add(CompanyMainData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./List");
        }
    }
}
