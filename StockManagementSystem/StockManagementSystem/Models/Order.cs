using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagementSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }    
        public decimal OrderAmount { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        [BindNever]
        public virtual Customer Customer { get; set; }

    }
}
