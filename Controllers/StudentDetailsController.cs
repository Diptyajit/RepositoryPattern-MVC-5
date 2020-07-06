using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryPatternExp.Models;
using RepositoryPatternExp.Repository;


namespace RepositoryPatternExp.Controllers
{
    public class StudentDetailsController : Controller
    {

        private IStudentRepository studentRepository;
        public StudentDetailsController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        // GET: StudentDetails
        //////////////private IStudentRepository _studentgRepository;

        //////////////public StudentDetailsController()
        //////////////{
        //////////////    this._studentgRepository = new StudentRepository(new ReoPDbEntities());
        //////////////}

        public ActionResult Index()
        {
            //////var books = from StudentDetails in _studentgRepository.GetStudents()
            //////                 select StudentDetails;
            //////return View(books);
            ///
            return View(studentRepository.GetStudents());
        }

        // GET: StudentDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentDetails/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
