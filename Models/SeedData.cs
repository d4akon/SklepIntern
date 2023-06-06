using Microsoft.EntityFrameworkCore;
using SklepInternetowy.Data;

namespace SklepInternetowy.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SklepInternetowyContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<SklepInternetowyContext>>()))
        {
            if (context == null || context.Product == null)
            {
                throw new ArgumentNullException("Null SklepInternetowyContext");
            }

            // Look for any movies.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            List<Product> mockupProducts = new List<Product>();

            Product product1 = new Product
            {
                Name = "Smartphone",
                Description = "A high-performance smartphone with advanced features.",
                Price = 599.99m,
                Category = "Electronics",
                ImageUrl = "https://opsg-img-cdn-gl.heytapimg.com/epb/202302/15/SrtL7TwcCqYXBAln.png",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product1);

            Product product2 = new Product
            {
                Name = "Laptop",
                Description = "A powerful laptop for both work and entertainment purposes.",
                Price = 1299.99m,
                Category = "Electronics",
                ImageUrl = "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE4LqQX?ver=1f00&q=90&m=6&h=705&w=1253&b=%23FFFFFFFF&f=jpg&o=f&p=140&aim=true",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product2);

            Product product3 = new Product
            {
                Name = "Running Shoes",
                Description = "Comfortable and lightweight running shoes for athletes.",
                Price = 89.99m,
                Category = "Sports",
                ImageUrl = "https://static.nike.com/a/images/t_default/514c0c6c-8c60-4d65-94c4-73158a3028be/invincible-3-mens-road-running-shoes-Xrd0px.png",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product3);

            Product product4 = new Product
            {
                Name = "Headphones",
                Description = "Premium wireless headphones with noise cancellation.",
                Price = 199.99m,
                Category = "Electronics",
                ImageUrl = "https://www.sony.pl/image/5d02da5df552836db894cead8a68f5f3?fmt=png-alpha&wid=440",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product4);

            Product product5 = new Product
            {
                Name = "Dress Shirt",
                Description = "Elegant dress shirt for formal occasions.",
                Price = 49.99m,
                Category = "Fashion",
                ImageUrl = "https://image.josbank.com/is/image/JosBank/25796_240_main?$pgp_desktop_thumbnail_lg$",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product5);
            
            Product product6 = new Product
            {
                Name = "Fitness Tracker",
                Description = "A wearable device to track your fitness activities and monitor health.",
                Price = 79.99m,
                Category = "Electronics",
                ImageUrl = "https://www.acme.eu/sites/default/files/styles/max_1000x1000/public/field_images/2021-07/5_2_0_3_3_2_cff4f556caa38f5688f3ca582086c7cb_original.tif.png?itok=mASxROC2",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product6);

            Product product7 = new Product
            {
                Name = "Coffee Maker",
                Description = "An advanced coffee maker that brews delicious coffee in minutes.",
                Price = 59.99m,
                Category = "Home Appliances",
                ImageUrl = "https://storycoffee.pl/wp-content/uploads/2020/07/a496cae2c6cb59a21b01332d56fa97ea-removebg-preview.png",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product7);

            Product product8 = new Product
            {
                Name = "Wireless Mouse",
                Description = "A compact and ergonomic wireless mouse for effortless navigation.",
                Price = 24.99m,
                Category = "Computer Accessories",
                ImageUrl = "https://resource.logitechg.com/w_1206,c_limit,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/gaming/en/products/pro-wireless-gaming-mouse/pro-wireless-carbon-gallery-1.png?v=1",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product8);

            Product product9 = new Product
            {
                Name = "Yoga Mat",
                Description = "A high-quality yoga mat for comfortable workouts and stretching.",
                Price = 39.99m,
                Category = "Sports",
                ImageUrl = "https://www.johnsonfitness.com/Content/product_images/GF-2XYOGA.png",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product9);

            Product product10 = new Product
            {
                Name = "Sunglasses",
                Description = "Stylish sunglasses that provide UV protection and enhance your style.",
                Price = 59.99m,
                Category = "Fashion",
                ImageUrl = "https://assets.lenscrafters.com/is/image/LensCrafters/8053672770421__001.png",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product10);

            Product product11 = new Product
            {
                Name = "Bluetooth Speaker",
                Description = "A portable Bluetooth speaker for immersive audio experience.",
                Price = 79.99m,
                Category = "Electronics",
                ImageUrl = "https://pl.jbl.com/dw/image/v2/AAUJ_PRD/on/demandware.static/-/Sites-masterCatalog_Harman/default/dwd56ceea6/1_JBL_BOOMBOX_3_HERO_BLACK_33216_x2.png?sw=537&sfrm=png",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product11);

            Product product12 = new Product
            {
                Name = "Handbag",
                Description = "A fashionable handbag with ample storage space for everyday essentials.",
                Price = 89.99m,
                Category = "Fashion",
                ImageUrl = "https://www.ripani.com/media/immagini/226_n_9292OF.00027_1.webp",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product12);

            Product product13 = new Product
            {
                Name = "Power Bank",
                Description = "A portable power bank to keep your devices charged on the go.",
                Price = 29.99m,
                Category = "Electronics",
                ImageUrl = "https://cdn.shopify.com/s/files/1/0687/0463/3147/products/4956_baseus_bipow_digital_display_power_bank_15w-20000mah-1-base-640px_ac19e06e-fc12-4597-bbb9-fe76fb3e710a.png?v=1679747413",
                CreatedAt = DateTime.Now
            };
            mockupProducts.Add(product13);
            
            context.Product.AddRange(mockupProducts);
            
            context.SaveChanges();
        }
    }

}