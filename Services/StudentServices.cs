using System.Collections.Generic;
using T_System_Web_Api.Model;
using T_System_Web_Api.Repositories;

namespace T_System_Web_Api.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudnentRepository istudRepository;

        public StudentServices(IStudnentRepository istudRepo)
        {
           istudRepository = istudRepo;
        }
        public int AddStudent(Student student)
        {
              return istudRepository.AddStudent(student);
        }

        public int DeleteStudent(int rollNo)
        {
            return istudRepository.DeleteStudent(rollNo);
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return istudRepository.GetAllStudents();
        }

        public int UpdateStudent(Student student)
        {
            return istudRepository.UpdateStudent(student);
        }
    }
}
