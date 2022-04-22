using System.Collections.Generic;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Services
{
    public interface IEmployeesServices
    {
        IEnumerable<Employees> GetAllEmployees();
        int AddEmployee(Employees Emp);
        int UpdateEmployee(Employees Emp);
        int DeleteEmployee(int EmpID);

    }
}
