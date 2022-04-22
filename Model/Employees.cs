using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace T_System_Web_Api.Model
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public decimal EmpSalary { get; set; }

    }
}
