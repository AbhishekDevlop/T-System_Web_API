using System.Collections.Generic;
using System.Linq;
using T_System_Web_Api.Entity;
using T_Syst    em_Web_Api.Model;
using System;
using System.Threading.Tasks;

namespace T_System_Web_Api.Repositories
{
    public class StudentRepository : IStudnentRepository
    {
        StudentContext context;

        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }
        public int AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return 1;

        }

        public int DeleteStudent(int rollNo)
        {
          //  var res =  from s in context.Students where s.rollNo == rollNo select s;
            var res = context.Students.Where(s => s.rollNo == rollNo).SingleOrDefault();
            if (res != null) 
            {
                context.Remove(res);
                context.SaveChanges();
                return 1;
            }
            else { return 0; }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            //var stud = from s in context.Students where s.rollNo == student.rollNo select s;
            var stud = context.Students.Where(s => s.rollNo == student.rollNo).SingleOrDefault();
            if(stud != null) 
            {
                stud.name = student.name;
                stud.percentage = student.percentage;
                context.SaveChanges();
                return 1;
            }
            else { return 0; }
        }
    }
}
