using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.net5RazorPagesExample.Data;
using Asp.net5RazorPagesExample.Models;

namespace Asp.net5RazorPagesExample.Areas.User.Pages
{
    public class HomeModel : PageModel
    {
        private readonly Asp.net5RazorPagesExample.Data.DBContext _context;

        public HomeModel(Asp.net5RazorPagesExample.Data.DBContext context)
        {
            _context = context;
        }

        public CompanyMainData CompanyMainData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id=1)
        {
            if (id == null)
            {
                return NotFound();
            }

            CompanyMainData = await _context.CompanyMainDatas.FirstOrDefaultAsync(m => m.Id == id);

            if (CompanyMainData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
