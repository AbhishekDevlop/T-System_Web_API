using Microsoft.AspNetCore.Mvc;
using T_System_Web_Api.Model;
using T_System_Web_Api.Services;

namespace T_System_Web_Api.Controllers
{
    public class CourseController : ControllerBase
    {
        private readonly IcourseServices icourseserv;

        public CourseController(IcourseServices icourseserv)
        {
            this.icourseserv = icourseserv;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Course/GetCourses")]
        public IActionResult GetAllCourses()
        {
            return new ObjectResult(icourseserv.GetAllCourses());
        }

        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(Course course)
        {
            return new ObjectResult(icourseserv.AddCourse(course));
        }
        [HttpPost]
        [Route("UpdateCourse")]
        public IActionResult UpdateCourse(Course course)
        {
            return new ObjectResult(icourseserv.UpdateCourse(course));
        }

        [HttpGet]
        [Route("DeleteCourse/{CourseId}")]
        public IActionResult DeleteStudent(int CourseId)
        {
            return new ObjectResult(icourseserv.DeleteCourse(CourseId));
        }

    }
}
