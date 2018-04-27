using akademij.Application.main.employee.dto;
using akademij.EF.repositories;
using AutoMapper;
using System.Collections.Generic;

namespace akademij.Application.main.employee
{
    public class EmployeeService : IEmployeeService
    {
        protected readonly IEmployeeRepository _employeeRepository;
        protected readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var list = _employeeRepository.GetEmployees();
            var listDto = _mapper.Map<List<EmployeeDto>>(list);
            return listDto;
        }
    }
}
