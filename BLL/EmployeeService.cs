using Business.DAL;
using Business.Models; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.BLL
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _repository;

        public EmployeeService()
        {
            _repository = new EmployeeRepository();
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            var employees = await _repository.GetAllEmployeesAsync();
            foreach (var emp in employees)
            {
                emp.employee_annual_salary = emp.employee_salary * 12;
            }
            return employees;
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var emp = await _repository.GetEmployeeByIdAsync(id);
            if (emp != null)
            {
                emp.employee_annual_salary = emp.employee_salary * 12;
            }
            return emp;
        }
    }
}
