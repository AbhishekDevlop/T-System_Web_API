using System;
using System.Collections.Generic;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Repositories
{
    public interface IStudnentRepository
    {
        IEnumerable<Student>GetAllStudents();
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int studentId);

    }
}
