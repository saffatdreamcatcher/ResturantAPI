using Core.IRepository;
using Core.Models;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public TableController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("Get")]
        public IEnumerable<TableRequest> Get()
        {
            List<Table> tables = _unitOfWork.Table.GetAll().ToList();
            List<TableRequest> tableRequests = tables.Select(u => new TableRequest()
            {
                TableId = u.Id,
                TableNumber = u.TableNumber
            }).ToList();

            return tableRequests;
        }

        [HttpGet("Get/{Id}")]
        public TableRequest Get(int Id)
        {

            Table? table = _unitOfWork.Table.Find(Id);
            TableRequest request = new TableRequest();
            request.TableId = table.Id;
            request.TableNumber = table.TableNumber;
            return request;

        }

        [HttpPost("Create")]
        public Task Create(CUTableRequest request)
        {

            Table table = new Table();
            table.TableNumber = request.TableNumber;
            table.NumberOfSeats = request.NumberOfSeats;
            table.Image = request.Image;
            _unitOfWork.Table.Add(table);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }

        [HttpPut("Update/{id}")]
        public Task Update(int id, CUTableRequest request)
        {

            Table? table = _unitOfWork.Table.Find(id);
            table.TableNumber = request.TableNumber;
            table.NumberOfSeats = request.NumberOfSeats;
            table.Image = request.Image;
            _unitOfWork.Table.Update(table);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }

        [HttpDelete("Delete/{id}")]
        public Task Delete(int id, DeleteTableRequest request)
        {
            Table? table = _unitOfWork.Table.Find(id);
            _unitOfWork.Table.Remove(table);
            _unitOfWork.Save();
            return Task.CompletedTask;
        }


    }
}
