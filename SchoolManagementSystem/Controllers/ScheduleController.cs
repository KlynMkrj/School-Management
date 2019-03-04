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
    public class ScheduleController : Controller
    {
        IService _service;

        public ScheduleController(IService service)
        {
            _service = service;
        }


        public ActionResult AddSchedule()
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

        public ActionResult SaveSchedule(Schedule schedule)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewData["OperationMessage"] = _service.SaveSchedule(schedule);
                    return View("OperationResult");
                }
                else
                {
                    return View("AddSchedule");
                }
            }
            catch
            {
                return View("HandledException");
            }
        }
    }
}