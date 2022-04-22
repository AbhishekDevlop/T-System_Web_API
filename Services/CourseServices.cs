using System.Collections.Generic;
using T_System_Web_Api.Model;
using T_System_Web_Api.Repositories;

namespace T_System_Web_Api.Services
{
    public class CourseServices : IcourseServices
    {
        private readonly ICourseRepository courseRepository;

            public CourseServices(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public int AddCourse(Course course)
        {
            return courseRepository.AddCourse(course);
        }

        public int DeleteCourse(int CourseId)
        {
            return courseRepository.DeleteCourse(CourseId);
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return courseRepository.GetAllCourses();
        }

        public int UpdateCourse(Course course)
        {
            return courseRepository.UpdateCourse(course);
        }
    }
}
