using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_System_Web_Api.Model;

namespace T_System_Web_Api.Services
{
    public interface IStudentServices
    {
        IEnumerable<Student> GetAllStudent();
        int AddStudent (Student student);
        int UpdateStudent (Student student);
        int DeleteStudent (int id);
        
    }
}
