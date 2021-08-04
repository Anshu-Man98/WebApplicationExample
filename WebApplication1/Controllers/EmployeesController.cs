using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeDataOperations _employeeDataOperation;

        public EmployeesController(IEmployeeDataOperations employeeDataOperation)
        {
            _employeeDataOperation = employeeDataOperation;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<JsonResult> AddDetails(string firstName, string lastName, string gId, string email, DateTime lastWorkingDate)
        {
            var updateStatus = await _employeeDataOperation.AddEmployeeData(firstName, lastName, gId, email, lastWorkingDate);
            return Json("");


        }

    }
}
