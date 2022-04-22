using System;
using System.Collections.Generic;
using System.Linq;
using T_System_Web_Api.Entity;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Repositories
{
    public class EmployeesRepository:IEmployeesRepository
    {
        StudentContext context;

        public EmployeesRepository(StudentContext context)
        {
            this.context = context;
        }

        public int AddEmployee(Employees Emp)
        {
            context.Employees.Add(Emp);
            context.SaveChanges();
            return 0;

        }

        public int DeleteEmployee(int EmpID)
        {
            var result = context.Employees.Where(e => e.EmpID == EmpID).SingleOrDefault();
            if(result != null) 
            {
                context.Employees.Remove(result);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public int UpdateEmployee(Employees Emp)
        {
            var r = context.Employees.Where(e => e.EmpID == Emp.EmpID).SingleOrDefault();
            if(r != null) 
            {
                r.EmpName = Emp.EmpName;
                r.EmpSalary = Emp.EmpSalary;
                context.SaveChanges();
                return 1;
            }
            else {return 0;}
        }
    }
}
