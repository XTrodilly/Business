using Business.BLL; 
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Business.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _service;

        public EmployeeController()
        {
            _service = new EmployeeService();
        }

        public async Task<ActionResult> Index(int? id)
        {
            if (id.HasValue)
            {
                var employee = await _service.GetEmployeeByIdAsync(id.Value);
                if (employee != null)
                    return View("Index", new[] { employee });
                else
                    ViewBag.Message = "Empleado no encontrado.";
            }
            else
            {
                var employees = await _service.GetAllEmployeesAsync();
                return View("Index", employees);
            }

            return View("Index", new object[0]);
        }
    }
}
