using SklepInternetowy.Enums;
using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public CategoryEnum Category { get; set; }
        public string? ImageUrl { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
    }
}
