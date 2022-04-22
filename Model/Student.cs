using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T_System_Web_Api.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int rollNo { get; set; }
        public string name { get; set; }
        public decimal percentage { get; set; }
    }
}
