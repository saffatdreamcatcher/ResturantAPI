using Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {
            
        }

        [HttpPost("Create")]
        public Task Create(CreateStudentRequest request)
        {
            return Task.CompletedTask;
        }

        [HttpGet("Get")]
        public Task<IEnumerable<GetStudentResponse>> Get()
        {
            return null;
        }
    }
}
