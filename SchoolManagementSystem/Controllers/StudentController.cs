using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Services.ExtMethods;
using SchoolManagementSystem.ViewModels;

namespace SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        IService _service;

        public StudentController(IService service)
        {
            _service = service;
        }


        public ActionResult AddStudent()
        {
            try
            {                
                return View();                
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult SaveStudent(Student student)
        {
            try
            {
                Student objStudent = _service.SaveStudent(student);

                ViewData["OperationMessage"] = "Student created successfully. Roll no. : " + objStudent.RollNo + ". Standard : " + objStudent.Standard + "th";
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult SearchStudent()
        {
            try
            {
                return View();
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult ManegeStudent(Student student)
        {
            try
            {                
                StudentVM objStudentVM = _service.SearchStudent(student);

                TempData.Put<StudentVM>("SearchedStudent", objStudentVM);

                return View(objStudentVM);
            }
            catch 
            {
                return View("HandledException");
            }
        }

        public ActionResult UpdateStudent(Student student)
        {
            try
            {
                StudentVM objStudentVM;

                objStudentVM = TempData.Get<StudentVM>("SearchedStudent");

                ViewData["OperationMessage"] = _service.UpdateStudent(objStudentVM);
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult DeleteStudent(Student student)
        {
            try
            {                
                StudentVM objStudentVM;

                objStudentVM = TempData.Get<StudentVM>("SearchedStudent");

                ViewData["OperationMessage"] = _service.DeleteStudent(objStudentVM);
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }
        
    }
}