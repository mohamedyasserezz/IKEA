using LinkDev.IKEA.BLL.Models.Departments;
using LinkDev.IKEA.BLL.Services.Departments;
using Microsoft.AspNetCore.Mvc;

namespace LinkDev.IKEA.PL.Controllers
{
    // Inheritance : DepartmentController is a Controller
    // Composition : DepartmentController has an IDepartmentService
    public class DepartmentController(
        IDepartmentService departmentService,
        ILogger<DepartmentController> logger,
        IWebHostEnvironment webHostEnvironment) : Controller
    {
        
        private readonly IDepartmentService _departmentService = departmentService;
        private readonly ILogger<DepartmentController> _logger = logger;
        private readonly IWebHostEnvironment _webHostEnvironment = webHostEnvironment;

        [HttpGet] // Get: Department/Index
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto department)
        {
            if(!ModelState.IsValid)
                return View(department);
            var Message= String.Empty;

            try
            {
                var Result = _departmentService.CreateDepartment(department);
                if (Result > 0) return RedirectToAction(nameof(Index));
                else
                {
                    Message = "Department is not Created";
                    ModelState.AddModelError(string.Empty, Message);
                    return View(department);
                }
            }
            catch (Exception ex)
            {
                // 1. Log Exceptions
                _logger.LogError(ex,ex.Message);

                // 2.Set Message
                if (_webHostEnvironment.IsDevelopment())
                {
                    Message = ex.Message;
                    return View(department);
                }
                else
                {
                    Message = "Department is not Created";
                    return View("Error", Message);
                }
            }
        }
    }
}
