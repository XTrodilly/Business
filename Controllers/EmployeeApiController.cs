using Business.BLL; 
using System.Threading.Tasks;  
using System.Web.Http;

namespace Business.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeApiController : ApiController
    {
        private readonly EmployeeService _service;

        public EmployeeApiController()
        {
            _service = new EmployeeService();
        }

        // GET: api/employee
        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetAll()
        {
            var employees = await _service.GetAllEmployeesAsync();
            return Ok(employees);
        }

        // GET: api/employee/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var employee = await _service.GetEmployeeByIdAsync(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }
    }
}
