using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.ViewModel;

namespace SchoolManagementSystem.Controllers
{
    public class StudentsController : Controller
    {
        IService service;

        public StudentsController(IService ser)
        {
            service = ser;
        }


        public ActionResult AddStudent()
        {
            return View();
        }

        public ActionResult SaveStudent(Student obj)
        {
            Student objStudent = new Student();
            objStudent = service.SaveStudent(obj);

            ViewData["OperationMessage"] = "Student created successfully. Roll no. : " + objStudent.RollNo + ". Standard : " + objStudent.Standard + "th";
            return View("OperationResult");
        }

        public ActionResult SearchStudent()
        {            
            return View();
        }

        public ActionResult ManegeStudent(Student obj)
        {
            StudentVM objVM = new StudentVM();
            objVM.RollNo = obj.RollNo;
            objVM.Name = obj.Name;
            objVM.Standard = obj.Standard;
            objVM.ContactNo = obj.ContactNo;
            return View(objVM);
        }

        public ActionResult UpdateStudent(Student obj)
        {
            ViewData["OperationMessage"] = "Student updated successfully. Roll no. : " + obj.RollNo + ". Standard : " + obj.Standard + "th";
            return View("OperationResult");
        }

        public ActionResult DeleteStudent(Student obj)
        {
            ViewData["OperationMessage"] = "Student deleted successfully. Roll no. : " + obj.RollNo + ". Standard : " + obj.Standard + "th";
            return View("OperationResult");
        }


        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Students/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}