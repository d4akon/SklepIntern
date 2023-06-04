using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SklepInternetowy.Models;

namespace SklepInternetowy.Data
{
    public class SklepInternetowyContext : DbContext
    {
        public SklepInternetowyContext (DbContextOptions<SklepInternetowyContext> options)
            : base(options)
        {
        }

        public DbSet<SklepInternetowy.Models.Product> Product { get; set; } = default!;
    }
}
