using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SchoolManagementSystem.Models;
using SchoolManagementSystem.Services;
using SchoolManagementSystem.Services.ExtMethods;
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
                if (ModelState.IsValid)
                {
                    ViewData["OperationMessage"] = _service.SaveCourse(course);
                    return View("OperationResult");
                }
                else
                {
                    return View("AddCourse");
                }
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
                if (ModelState.IsValid)
                {
                    CourseVM objCourseVM = _service.SearchCourse(course);

                    TempData.Put<CourseVM>("SearchedCourse", objCourseVM);

                    return View(objCourseVM);
                }
                else
                {
                    return View("SearchCourse");
                }
            }
            catch
            {
                return View("HandledException");
            }
        }
        
        public ActionResult DeleteCourse()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CourseVM objCourseVM;

                    objCourseVM = TempData.Get<CourseVM>("SearchedCourse");

                    ViewData["OperationMessage"] = _service.DeleteCourse(objCourseVM);
                    return View("OperationResult");
                }
                else
                {
                    return View("SearchCourse");
                }
            }
            catch
            {
                return View("HandledException");
            }
        }

    }
}