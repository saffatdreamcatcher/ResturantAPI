using Core.IRepository;
using Core.Models;
using Core.ViewModels;
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


        [HttpPost("Create")]
        public Task Create(CUOrderRequest request)
        {

            Order order = new Order();
            order.TableId = request.TableId;
            order.OrderNumber = request.OrderNumber;
            order.Amount = request.Amount;
            _unitOfWork.Order.Add(order);
            _unitOfWork.Save();
            var orderItems = new List<OrderItem>();
            foreach (var item in request.Items)
            {
                order.FoodId = item.FoodId;
                order.FoodPackageId = item.FoodPackageId;
                order.Quantity = item.Quantity;
                order.UnitPrice = item.UnitPrice;
                order.TotalPrice = item.TotalPrice;
            }
            _unitOfWork.OrderItem.AddRange(orderItems);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }

        [HttpPut("Update/{id}")]
        public Task Update(int id, CUOrderRequest request)
        {

            Order? order = _unitOfWork.Order.Find(id);
            order.TableId = request.TableId;
            order.OrderNumber = request.OrderNumber;
            order.Amount = request.Amount;
            var orderItems = new List<OrderItem>();
            foreach (var item in request.Items)
            {
                order.FoodId = item.FoodId;
                order.FoodPackageId = item.FoodPackageId;
                order.Quantity = item.Quantity;
                order.UnitPrice = item.UnitPrice;
                order.TotalPrice = item.TotalPrice;
            }
            _unitOfWork.OrderItem.AddRange(orderItems);
            _unitOfWork.Order.Update(order);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }

        [HttpDelete("Delete/{id}")]
        public Task Delete(int id, DeleteOrderRequest request)
        {
            Order? order = _unitOfWork.Order.Find(id);
            _unitOfWork.Order.Remove(order);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }



    }
}
