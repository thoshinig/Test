using Evaluation.Models;
using FirstProject.Models.Repository;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudenController : ControllerBase
    {
        private readonly IDataRepository<Student> _dataRepository;
       
        public StudenController(IDataRepository<Student> dataRepository)
        {
            _dataRepository=dataRepository;
        }
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    IEnumerable<Student> Student = _dataRepository.GetAll();
        //    return Ok(Student);
        //}
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            Student student = await _dataRepository.FiSamplefilters(id);
            return Ok(student);
        }
    }
}
