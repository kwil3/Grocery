using System.ComponentModel.DataAnnotations;

namespace RazorPagesGrocery.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}