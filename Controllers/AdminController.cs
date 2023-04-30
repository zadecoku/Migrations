using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Migrations.Data;
using System.Security.Claims;

namespace Migrations.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(ILogger<AdminController> logger,
            ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.Users.ToListAsync();
            foreach (var item in user)
            {
                var role = await _userManager.GetRolesAsync(item);
            }

            //var employeeDTOs = .employee.Select(x => new EmployeeDTO
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    Gender = x.Gender,
            //    DepartmentName = x.Department.Name,
            //    City = x.City
            //});
            return View(user);
        }

    }
}
