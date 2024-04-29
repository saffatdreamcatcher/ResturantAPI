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

            Table table = _unitOfWork.Table.Get(u => u.Id == Id);
            TableRequest request = new TableRequest();
            request.TableId = table.Id;
            request.TableNumber = table.TableNumber;
            return request;

        }
    }
}
