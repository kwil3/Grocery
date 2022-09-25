using System.ComponentModel.DataAnnotations;

namespace RazorPagesGrocery.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
    }
}