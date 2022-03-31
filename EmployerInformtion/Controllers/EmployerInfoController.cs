using EmployerInformtion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployerInformtion.Controllers
{
    [Route("api/EmployeeInfo")]
    [ApiController]
    public class EmployerInfoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<EmployeeInfo> ListOfEmployees()
        {
            // create db connection
            var employeeInformation = new List<EmployeeInfo>();
            using (var context = new EmployeeDBContext())
            {
                employeeInformation = context.EmployeeInfos.ToList();
            }
            return employeeInformation;
        }
    }
}
