using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SklepInternetowy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public string? ImageUrl { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
    }
}
