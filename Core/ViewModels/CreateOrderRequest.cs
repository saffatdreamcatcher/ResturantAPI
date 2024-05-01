using Core.Models;

namespace Core.ViewModels
{
    public class CreateOrderRequest
    {
        public int Id { get; set; } 
        public int TableId { get; set; } 
        public string OrderNumber { get; set; } 
        public string Amount { get; set; } 
        public string PhoneNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
       
    }
}
