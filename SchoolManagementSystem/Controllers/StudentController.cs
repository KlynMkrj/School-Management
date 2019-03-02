﻿using System;
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
    public class StudentController : Controller
    {
        IService service;

        public StudentController(IService ser)
        {
            service = ser;
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
                Student objStudent = service.SaveStudent(student);

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
                StudentVM objStudentVM = new StudentVM();
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

        public ActionResult UpdateStudent(Student obj)
        {
            try
            {
                ViewData["OperationMessage"] = "Student updated successfully. Roll no. : " + obj.RollNo + ". Standard : " + obj.Standard + "th";
                return View("OperationResult");
            }
            catch
            {
                return View("HandledException");
            }
        }

        public ActionResult DeleteStudent(Student obj)
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