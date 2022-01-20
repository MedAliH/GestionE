using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace blazorApp.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<HttpResponseMessage> UpdateEmployee(Employee updatedEmployee);
    }
}
