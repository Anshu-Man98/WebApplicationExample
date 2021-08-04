using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interface
{
    interface IEmployeeDataOperations
    {
        Task<bool> AddEmployeeData(string firstName, string lastName, string gId, string email, DateTime lastWorkingDate);
    }
}
