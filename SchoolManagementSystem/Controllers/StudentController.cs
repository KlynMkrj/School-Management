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
                if (ModelState.IsValid)
                {                    
                    ViewData["OperationMessage"] = _service.SaveStudent(student);
                    return View("OperationResult");
                }
                else
                {
                    return View("AddStudent");
                }
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
                if (ModelState.IsValid)
                {
                    StudentVM objStudentVM = _service.SearchStudent(student);

                    TempData.Put<StudentVM>("SearchedStudent", objStudentVM);

                    return View(objStudentVM);
                }
                else
                {
                    return View("SearchStudent");
                }
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
                if (ModelState.IsValid)
                {
                    StudentVM objStudentVM;

                    objStudentVM = TempData.Get<StudentVM>("SearchedStudent");

                    ViewData["OperationMessage"] = _service.UpdateStudent(objStudentVM);
                    return View("OperationResult");
                }
                else
                {
                    return View("SearchStudent");
                }
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
                if (ModelState.IsValid)
                {
                    StudentVM objStudentVM;

                    objStudentVM = TempData.Get<StudentVM>("SearchedStudent");

                    ViewData["OperationMessage"] = _service.DeleteStudent(objStudentVM);
                    return View("OperationResult");
                }
                else
                {
                    return View("SearchStudent");
                }
            }
            catch
            {
                return View("HandledException");
            }
        }
        
    }
}