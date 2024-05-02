using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public DateTime OrderTime { get; set ; } = DateTime.Now;
        public int TableId { get; set; }
        public Table Table { get; set; }
        public int? FoodId { get; set; }
        public int? FoodPackageId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } 

    }
}
