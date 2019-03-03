﻿using System;
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
                Course objCourse = _service.SaveCourse(course);

                ViewData["OperationMessage"] = "Course created successfully. Course ID. : " + objCourse.CourseId + ". Course name : " + objCourse.Name + "th";
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
                CourseVM objCourseVM = new CourseVM();
                objCourseVM.CourseId = course.CourseId;
                objCourseVM.Name = course.Name;
               
                return View(objCourseVM);
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult DeleteCourse(Course course)
        {
            try
            {
                ViewData["OperationMessage"] = "Course deleted successfully. Course ID. : " + course.CourseId + ". Course Name : " + course.Name;
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }

    }
}