using System.Collections.Generic;
using T_System_Web_Api.Model;
using T_System_Web_Api.Entity;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace T_System_Web_Api.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        StudentContext context;

        public CourseRepository(StudentContext context)
        {
            this.context = context;
        }
        public int AddCourse(Course course)
        {
            context.Courses.Add(course);
            
            context.SaveChanges();
            return 1;
        }

        public int DeleteCourse(int CourseId)
        {
            var res = context.Courses.Where(c => c.CourseId == CourseId).SingleOrDefault();
            if (res != null)
            {
                context.Remove(res);
                context.SaveChanges();
                return 1;
            }
            else { return 0; }
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return  context.Courses.ToList();
        }

        public int UpdateCourse(Course course)
        {
          var cour = context.Courses.Where(c =>c.CourseId == course.CourseId).SingleOrDefault();
            if (cour != null)
            {
                cour.CourseName= course.CourseName;
                cour.CoursePrice= course.CoursePrice;
                context.SaveChanges();
                return 1;
            }
            else { return 0; }
        }
    }
}
