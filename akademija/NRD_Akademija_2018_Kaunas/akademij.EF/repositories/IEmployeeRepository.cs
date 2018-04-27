using akademij.EF.entities;
using System.Collections.Generic;

namespace akademij.EF.repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
