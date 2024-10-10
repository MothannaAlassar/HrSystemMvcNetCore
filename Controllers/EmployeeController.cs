using HrSystem.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class EmployeeController : BaseBasicController
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
            var lang = GetDefaultLang();
            return RedirectToView($"Index", model);
        }
        // GET: Employee/Details/3
        public ActionResult Details(int id)
        {
            var model = new Models.EmployeeViewModel();
            var employee = employeeRepo.Find(id);
            model.Id = employee.Id;
            model.Name_Ar = employee.First_Name_Ar;
            model.Name_En = employee.First_Name_En;
            return RedirectToView($"Details", model);
        }
        // GET: Employee/Create
        public ActionResult Create()
        {
            var model = new Models.EmployeeViewModel
            {
                Id = 0
            };
            return RedirectToView($"Create", model);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.EmployeeViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var employee = new Data.Employee
                    {
                        Id = model.Id,
                        First_Name_Ar = model.Name_Ar,
                        First_Name_En = model.Name_En,
                    };

                    employeeRepo.Add(employee);

                    return RedirectToAction(nameof(Index));
                }
                catch
                {

                    return RedirectToView($"Create", model);
                }
            }


            ModelState.AddModelError("", "You have to fill all the required fields!");

            return RedirectToView($"Create", model);
        }
        // GET: Employee/Edit/3
        public ActionResult Edit(int id)
        {
            var employee = employeeRepo.Find(id);

            var viewModel = new Models.EmployeeViewModel
            {
                Id = employee.Id,
                Name_En = employee.First_Name_En,
                Name_Ar = employee.First_Name_Ar,
            };
            return RedirectToView($"Edit", viewModel);
        }

        // POST: Employee/Edit/3
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.EmployeeViewModel viewModel)
        {
            try
            {
                // TODO: Add update logic here
                var employee = new Data.Employee
                {
                    Id = viewModel.Id,
                    First_Name_Ar = viewModel.Name_Ar,
                    First_Name_En = viewModel.Name_En,
                };

                employeeRepo.Update(viewModel.Id, employee);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToView($"Edit", viewModel);
            }
        }
        // GET: Employee/Delete/5
        public IActionResult Delete(int id)
        {
            var employee = employeeRepo.Find(id);
            var model = new Models.EmployeeViewModel();
            model.Id = id;
            model.Name_Ar = employee.First_Name_Ar;
            model.Name_En = employee.First_Name_En;
            return RedirectToView($"Delete", model);
        }

        //POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmDelete(int id)
        {
            var model = new Models.EmployeeViewModel();
            model.Id = id;
            try
            {
                employeeRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction($"Delete", model);
            }
        }

    }
}
