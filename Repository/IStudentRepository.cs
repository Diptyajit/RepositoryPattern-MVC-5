using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepositoryPatternExp.Models;

namespace RepositoryPatternExp.Repository
{
    public interface IStudentRepository 
    {
        IEnumerable<StudentDetails> GetStudents();
       
        StudentDetails GetStudents(int id);
        void CreateStudent(int id);
        void UpdateStudent(int id);
        void DeleteStudent(int id);
    }
}
