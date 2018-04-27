using akademij.EF.entities;
using akademija.EF.repositories;
using System.Linq;

namespace akademij.EF.repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(NRDAkademijaKaunasContext context) : base(context)
        {
        }

        // public List<Employee> GetEmployees()
        public void GetEmployees()
        {
            var kintamasis1 = NRDAkademijaKaunasContext.Employee.ToList();

            var kint2 = NRDAkademijaKaunasContext.Employee.FirstOrDefault();

            var kint3 = NRDAkademijaKaunasContext.Employee.SingleOrDefault(p => p.FirstName == "Tomas");
            var kint4 = NRDAkademijaKaunasContext.Employee.Where(p => p.FirstName == "Kęstutis").Single();

            var kint5 = NRDAkademijaKaunasContext.Inventory.ToList();

            var kint6 = NRDAkademijaKaunasContext.Inventory.FirstOrDefault();
        }


        public NRDAkademijaKaunasContext NRDAkademijaKaunasContext
        {
            get { return Context as NRDAkademijaKaunasContext; }
        }
    }
}
