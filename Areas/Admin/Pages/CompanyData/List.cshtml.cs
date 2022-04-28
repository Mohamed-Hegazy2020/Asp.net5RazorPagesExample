using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.net5RazorPagesExample.Data;
using Asp.net5RazorPagesExample.Models;

namespace Asp.net5RazorPagesExample.Areas.Admin.Pages.CompanyData
{
    public class ListModel : PageModel
    {
        private readonly Asp.net5RazorPagesExample.Data.DBContext _context;

        public ListModel(Asp.net5RazorPagesExample.Data.DBContext context)
        {
            _context = context;
        }

        public IList<CompanyMainData> CompanyMainData { get;set; }

        public async Task OnGetAsync()
        {
            CompanyMainData = await _context.CompanyMainDatas.ToListAsync();
        }
    }
}
