using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.ViewModels;

namespace SchoolManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        IService _service;

        public CourseController(IService service)
        {
            _service = service;
        }


        public ActionResult AddCourse()
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

        public ActionResult SaveCourse(Course course)
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

        public ActionResult SearchCourse()
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

        public ActionResult ManegeCourse(Course student)
        {
            try
            {
                CourseVM objCourseVM = new CourseVM();
                objStudentVM.RollNo = student.RollNo;
                objStudentVM.Name = student.Name;
                objStudentVM.Standard = student.Standard;
                objStudentVM.ContactNo = student.ContactNo;
                return View(objStudentVM);
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult DeleteCourse(Course obj)
        {
            try
            {
                ViewData["OperationMessage"] = "Student deleted successfully. Roll no. : " + obj.RollNo + ". Standard : " + obj.Standard + "th";
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }

    }
}