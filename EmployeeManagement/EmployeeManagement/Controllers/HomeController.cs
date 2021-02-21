using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeReopsitory;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeReopsitory = employeeRepository;
        }
        public string Index() {
            return _employeeReopsitory.GetEmployee(1).Name;
        }
    }
}
