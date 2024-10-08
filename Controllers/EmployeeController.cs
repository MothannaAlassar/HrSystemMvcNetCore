using HrSystem.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly Repositories.IEmployeeRepo employeeRepo;
        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = new Models.EmployeeViewModel();
            var rtv = employeeRepo.List();
            model.Employees = rtv?.ToList();
            return View(model);
        }
    }
}
