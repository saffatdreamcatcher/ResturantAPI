using Core.IRepository;
using Core.Models;
using Core.ViewModels;
using DataAccess.Migrations;
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



        [HttpGet("Get")]
        public IEnumerable<GetOrderRequest> Get()
        {
            List<Order> orders = _unitOfWork.Order.GetAll().ToList();
            List<GetOrderRequest> orderRequests = orders.Select(o => new GetOrderRequest()
            {
                OrderId = o.Id,
                OrderNumber = o.OrderNumber
            }).ToList();

            return orderRequests;
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
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var item in request.Items)
            {
                orderItems.Add(new OrderItem
                {
                    OrderId = order.Id,
                    FoodId = item.FoodId,
                    FoodPackageId = item.FoodPackageId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    TotalPrice = item.TotalPrice
                });

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
                orderItems.Add(new OrderItem
                {
                    OrderId = order.Id,
                    FoodId = item.FoodId,
                    FoodPackageId = item.FoodPackageId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    TotalPrice = item.TotalPrice
                });

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
