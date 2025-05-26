using Business.Models; 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Business.DAL
{
    public class EmployeeRepository
    {
        private readonly string baseUrl = "https://68328e47c3f2222a8cb2aa04.mockapi.io";

        private HttpClient client;

        public EmployeeRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            var response = await client.GetAsync("/Employees");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var employees = JsonConvert.DeserializeObject<List<Employee>>(result);
                return employees;
            }

            return new List<Employee>();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var response = await client.GetAsync($"/Employees/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var employee = JsonConvert.DeserializeObject<Employee>(result);
                return employee;
            }

            return null;
        }

         
    }
}

