using System.Collections.Generic;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        int AddCourse(Course course);
        int UpdateCourse(Course course);
        int DeleteCourse(int CourseId);

    }
}
