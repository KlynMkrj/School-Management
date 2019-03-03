using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
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
                ViewData["OperationMessage"] = _service.SaveCourse(course);
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

        public ActionResult ManegeCourse(Course course)
        {
            try
            {
                CourseVM objCourseVM = _service.SearchCourse(course);

                TempData["SearchedCourse"] = JsonConvert.SerializeObject(objCourseVM);

                return View(objCourseVM);
            }
            catch
            {
                return View("HandledException");
            }
        }

        //public ActionResult DeleteCourse(Course course)
        public ActionResult DeleteCourse()
        {
            try
            {
                CourseVM objCourseVM = new CourseVM();
                objCourseVM = (CourseVM)JsonConvert.DeserializeObject(TempData["SearchedCourse"].ToString());
                ViewData["OperationMessage"] = _service.DeleteCourse(objCourseVM);
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }

    }
}