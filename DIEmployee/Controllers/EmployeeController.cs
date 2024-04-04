using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DIEmployee.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILoggerService _loggerService;

        public EmployeeController(IEmployeeService employeeService, ILoggerService loggerService)
        {
            _employeeService = employeeService;
            _loggerService = loggerService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            _loggerService.Log("Retrieved all Employees");
            return Ok(employees);
        }
    }
}
