using HrSystem.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class DepartmentController : BaseBasicController
    {
        private readonly Repositories.IDepartmentRepo departmentRepo;

        public DepartmentController(IDepartmentRepo departmentRepo)
        {
            this.departmentRepo = departmentRepo;
        }
        [Authorize]
        public IActionResult Index()
        {
            var model = new Models.DepartmentViewModel();
            var rtv = departmentRepo.List();
            model.Departments = rtv?.ToList();
            var lang = GetDefaultLang();
            return View($"{lang}/Index", model);
        }
    }
}
