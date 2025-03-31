using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagementSystem.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; } 
        public string CustomerName { get; set; }
        public string City { get; set; }  
    }
}
