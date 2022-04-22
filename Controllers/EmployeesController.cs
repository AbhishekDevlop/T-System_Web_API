using Microsoft.AspNetCore.Mvc;
using T_System_Web_Api.Model;
using T_System_Web_Api.Services;

namespace T_System_Web_Api.Controllers
{
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesServices iempserv;

        public EmployeesController(IEmployeesServices iempserv)
        {
            this.iempserv = iempserv;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employess/GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new ObjectResult(iempserv.GetAllEmployees());
        }
        [HttpPost]
        [Route("AddEmployees")]
        public IActionResult AddEmployee(Employees emp)
        {
            return new ObjectResult(iempserv.AddEmployee(emp));
        }


        [HttpPost]
        [Route("UpdateEmployees")]
        public IActionResult UpdateEmployee(Employees emp)
        {
            return new ObjectResult(iempserv.UpdateEmployee(emp));
        }
        [HttpGet]
        [Route("DeleteEmployee/{EmpId}")]
        public IActionResult DeleteEmployee(int EmpId)
        {
            return new ObjectResult(iempserv.DeleteEmployee(EmpId));
        }

    }
}
