using akademij.Application.main.employee.dto;
using System.Collections.Generic;

namespace akademij.Application.main.employee
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAllEmployees();
    }
}