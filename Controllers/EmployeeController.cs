using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Migrations.Data;
using Migrations.Models;
using Migrations.Models.DTO;

namespace Migrations.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly ApplicationDbContext _context;

        public EmployeeController(ILogger<EmployeeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: EmployeeController
        public async Task<ActionResult> Index()
        {
            var employee = await _context.Employees
                .Include(y => y.Department)
                .ToListAsync();

            var employeeDTOs = employee.Select(x => new EmployeeDTO
            {
                Id = x.Id,
                Name = x.Name,
                Gender = x.Gender,
                DepartmentName = x.Department.Name,
                City = x.City
            });

            return View(employeeDTOs);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(emp);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Employee employeeModel = new Employee();
                    employeeModel.Name = employee.Name;
                    employeeModel.DateCreated = DateTime.Now;
                    employeeModel.DepartmentId = 1;
                    employeeModel.City = employee.City;
                    employeeModel.Gender = employee.Gender;
                    employeeModel.PostalCode = employee.PostalCode;
                    _context.Employees.Add(employeeModel);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee emp = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(emp);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                var employeeData = _context.Employees.Where(x => x.Id == id).FirstOrDefault();
                if (employeeData != null)
                {
                    employeeData.Name = employee.Name;
                    employeeData.DateUpdated = DateTime.Now;
                    employeeData.City = employee.City;
                    employeeData.DepartmentId = 2;
                    employeeData.Gender = employee.Gender;
                    _context.Employees.Update(employeeData);
                    _context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
