using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Categories { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? ProductCategory { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Product
                                            orderby m.Category
                                            select m.Category;

            var products = from m in _context.Product
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ProductCategory))
            {
                products = products.Where(x => x.Category == ProductCategory);
            }
            Categories = new SelectList(await genreQuery.Distinct().ToListAsync());
            Product = await products.ToListAsync();
        }

        public IActionResult OnPostAddToBasket(int id)
        {
            var selectedProduct = _context.Product.Find(id);

            if (selectedProduct != null)
            {
                var productListJson = HttpContext.Session.GetString("BasketProducts");
                var productList = !string.IsNullOrEmpty(productListJson)
                    ? JsonSerializer.Deserialize<List<Product>>(productListJson)
                    : new List<Product>();

                productList.Add(selectedProduct);

                var updatedListJson = JsonSerializer.Serialize(productList);

                HttpContext.Session.SetString("BasketProducts", updatedListJson);
            }

            return RedirectToPage();
        }
    }
}
