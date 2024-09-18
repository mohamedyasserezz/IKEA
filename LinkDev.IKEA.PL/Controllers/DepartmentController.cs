﻿using LinkDev.IKEA.BLL.Services.Departments;
using Microsoft.AspNetCore.Mvc;

namespace LinkDev.IKEA.PL.Controllers
{
    // Inheritance : DepartmentController is a Controller
    // Composition : DepartmentController has an IDepartmentService
    public class DepartmentController(IDepartmentService departmentService) : Controller
    {
        
        private readonly IDepartmentService _departmentService = departmentService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
