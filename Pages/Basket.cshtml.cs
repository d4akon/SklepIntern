using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SklepInternetowy.Models;
using System.Text.Json;

namespace SklepInternetowy.Pages
{
    public class BasketModel : PageModel
    {
        public List<Product> BasketProducts { get; set; } = new List<Product>();

        public void OnGet()
        {
            // Retrieve the list of products from session
            var productListJson = HttpContext.Session.GetString("BasketProducts");

            if (!string.IsNullOrEmpty(productListJson))
            {
                // Deserialize the product list JSON string back to a List<Product> object
                BasketProducts = JsonSerializer.Deserialize<List<Product>>(productListJson);
            }
        }
    }
}
