using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Migrations.Data;
using Migrations.Models;
using Migrations.Models.DTO;
using System.Diagnostics;

namespace Migrations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Proffesor()
        {
            var proffesor = await _context.Proffesors
                .Include(y => y.Department)
                .ToListAsync();
            ViewBag.Head = "";
            var proffesorDTOs = proffesor.Select(x => new ProffesorDTO
            {
                Name = x.Name,
                BirthDate = x.BirthDate,
                DepartmentName = x.Department.Name
            });

            var employee = await _context.Employees
                .Include(y => y.Department)
                .ToListAsync();

            var employeeDTOs = employee.Select(x => new EmployeeDTO
            {
                Id=x.Id,
                Name = x.Name,
                Gender = x.Gender,
                DepartmentName = x.Department.Name,
                City = x.City
            });

            ViewBag.ProffesorEmployee = new ProffesorEmployeeDTO
            {
                Employee = employeeDTOs,
                Proffesor = proffesorDTOs
            };
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}