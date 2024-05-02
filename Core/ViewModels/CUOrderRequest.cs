using Core.Models;

namespace Core.ViewModels
{
    public class CUOrderRequest
    {
        public int Id { get; set; } 
        public int TableId { get; set; } 
        public string OrderNumber { get; set; } 
        public decimal Amount { get; set; } 
        public string PhoneNumber { get; set; }

        public List<OrderItemResource> Items { get; set; }

    }
}
