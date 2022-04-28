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
    public class ProductsModel : PageModel
    {
        private readonly Asp.net5RazorPagesExample.Data.DBContext _context;

        public ProductsModel(Asp.net5RazorPagesExample.Data.DBContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
