using System;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_System_Web_Api.Services;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Controllers
{
    public class StudentController:ControllerBase
    {
        private readonly IStudentServices istudser;
        public StudentController(IStudentServices istudser)
        {
            this.istudser = istudser;
        }

           [HttpGet]
        [Route("[action]")]
        [Route("api/Student/GetStudents")]
        public IActionResult GetStudents()
        {
            return new ObjectResult(istudser.GetAllStudent());
        }

        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            return new ObjectResult(istudser.AddStudent(student));
        }

         [HttpPost]
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            return new ObjectResult(istudser.UpdateStudent(student));
        }

        [HttpGet]
        [Route("DeleteStudent/{rollNo}")]
        public IActionResult DeleteStudent(int rollNo)
        {
            return new ObjectResult(istudser.DeleteStudent(rollNo));
        }

    }
}
