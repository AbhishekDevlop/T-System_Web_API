using System.Collections.Generic;
using T_System_Web_Api.Model;
using T_System_Web_Api.Repositories;

namespace T_System_Web_Api.Services
{
    public class EmployeesServices:IEmployeesServices
    {
        private readonly IEmployeesRepository iempRepo;

        public EmployeesServices(IEmployeesRepository iempRepo)
        {
            this.iempRepo = iempRepo;
        }

        public int AddEmployee(Employees Emp)
        {
            return iempRepo.AddEmployee(Emp);
        }

        public int DeleteEmployee(int EmpID)
        {
            return iempRepo.DeleteEmployee(EmpID);
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return iempRepo.GetAllEmployees();
        }

        public int UpdateEmployee(Employees Emp)
        {
            return iempRepo.UpdateEmployee(Emp);
        }
    }
}
