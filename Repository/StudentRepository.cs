using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositoryPatternExp.Models;
using Unity;

namespace RepositoryPatternExp.Repository
{
    public class StudentRepository : IStudentRepository
    {

        [Dependency]

        public ReoPDbEntities DbContext { get; set; }


        ////////private ReoPDbEntities _context;
        ////////public StudentRepository(ReoPDbEntities studentContext)
        ////////{
        ////////    this._context = studentContext;
        ////////}
        public IEnumerable<StudentDetails> GetStudents()
        {
            return DbContext.StudentDetailss.ToList();
        }
        public void CreateStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public StudentDetails GetStudents(int id)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable GetStudents()
        //{
        //    throw new NotImplementedException();
        //}

        public void UpdateStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}