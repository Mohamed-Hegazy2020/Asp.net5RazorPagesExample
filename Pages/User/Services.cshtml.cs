using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.net5RazorPagesExample.Data;
using Asp.net5RazorPagesExample.Models;

namespace Asp.net5RazorPagesExample.Pages.User
{
    public class ServicesModel : PageModel
    {
        private readonly Asp.net5RazorPagesExample.Data.DBContext _context;

        public ServicesModel(Asp.net5RazorPagesExample.Data.DBContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; }

        public async Task OnGetAsync()
        {
            Service = await _context.Services.ToListAsync();
        }
    }
}
