using Core.IRepository;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FoodController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("Get")]
        public IEnumerable<FoodRequest> Get()
        {
            List<Food> foods = _unitOfWork.Food.GetAll().ToList();
            List<FoodRequest> foodRequests = foods.Select(u => new FoodRequest()
            {
                FoodId = u.Id,
                Name = u.Name,
            }).ToList();

            return foodRequests;
        }


        [HttpGet("Get/{Id}")]
        public  FoodRequest Get(int Id)
        {

            Food food =  _unitOfWork.Food.Find(Id);
            FoodRequest request = new FoodRequest();
            request.FoodId = food.Id;
            request.Name = food.Name;
            return request;

        }


        [HttpPost("Create")]
        public Task Create(CUFoodRequest request)
        {
            Food food = new Food();
            food.Name = request.Name;
            food.Description = request.Description;
            food.Price = request.Price;
            food.Discount = request.Discount;
            food.DiscountType = request.DiscountType;
            food.DiscountPrice = request.DiscountPrice;
            food.Image = request.Image;
            _unitOfWork.Food.Add(food);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }



        [HttpPut("Update/{id}")]
        public Task Update(int id, CUFoodRequest request)
        {

            Food food = _unitOfWork.Food.Find(id);
            food.Name = request.Name;
            food.Description = request.Description;
            food.Price = request.Price;
            food.Discount = request.Discount;
            food.DiscountType = request.DiscountType;
            food.DiscountPrice = request.DiscountPrice;
            food.Image = request.Image;
            _unitOfWork.Food.Update(food);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }

        [HttpDelete("Delete/{id}")]
        public Task Delete(int id, DeleteFoodRequest request)
        {
            Food? food = _unitOfWork.Food.Find(id);
            _unitOfWork.Food.Remove(food);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }
    }
}
