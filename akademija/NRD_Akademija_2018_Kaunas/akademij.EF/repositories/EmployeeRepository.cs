using akademij.EF.entities;
using akademija.EF.repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace akademij.EF.repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(NRDAkademijaKaunasContext context) : base(context)
        {
        }

        public List<Employee> GetEmployees()
        {
            return NRDAkademijaKaunasContext.Employee
                .Include(p => p.EmployeeInventory)
                .ThenInclude(p => p.Inventory)
                .ToList();
        }


        public NRDAkademijaKaunasContext NRDAkademijaKaunasContext
        {
            get { return Context as NRDAkademijaKaunasContext; }
        }
    }
}
