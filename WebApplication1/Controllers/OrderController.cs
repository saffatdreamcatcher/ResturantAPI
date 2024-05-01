using Core.IRepository;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("Get/{Id}")]
        public void Get(int Id)
        {
           List<Order> orders =  _unitOfWork.Order.Get(o=> o.Id == Id);
           List<OrderItem> orderItems = _unitOfWork.OrderItem.Get(oi=> oi.OrderId == Id);
        }
    }
}
