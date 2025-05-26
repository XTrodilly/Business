using System;

namespace Business.Models
{
    public class Employee
    {
        public string id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }

        // Calculado en capa de lógica de negocio
        public int employee_annual_salary { get; set; }
    }
}
