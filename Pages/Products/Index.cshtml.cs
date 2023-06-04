using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SklepInternetowy.Data;
using SklepInternetowy.Models;

namespace SklepInternetowy.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly SklepInternetowy.Data.SklepInternetowyContext _context;

        public IndexModel(SklepInternetowy.Data.SklepInternetowyContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Product != null)
            {
                Product = await _context.Product.ToListAsync();
            }
        }
    }
}
