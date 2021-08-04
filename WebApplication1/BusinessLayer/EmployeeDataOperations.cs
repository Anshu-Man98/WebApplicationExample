using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.DataAccessLayer;
using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.BusinessLayer
{
    public class EmployeeDataOperations : IEmployeeDataOperations
    {
        private readonly EmployeeDeactivationContext _context;
        public EmployeeDataOperations(EmployeeDeactivationContext context)
        {
            _context = context;
        }
        public async Task<bool> AddEmployeeData(string firstName, string lastName, string gId, string email, DateTime lastWorkingDate)
        {
            EmployeeDeactivation employee = new EmployeeDeactivation()
            {
                Firstname = firstName,
                Lastname = lastName,
                GId = gId,
                Email = email,
                Date = lastWorkingDate
            };
            _context.Add(employee);
            var databaseUpdateStatus = await _context.SaveChangesAsync() == 1 ? true : false;
            return databaseUpdateStatus;
        }
    }
}

