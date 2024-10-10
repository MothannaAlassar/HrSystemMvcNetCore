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
            return RedirectToView($"Index", model);
        }
        // GET: Department/Details/3
        public ActionResult Details(int id)
        {
            var model = new Models.DepartmentViewModel();
            var department = departmentRepo.Find(id);
            model.Id = department.Id;
            model.Name_Ar = department.Name_Ar;
            model.Name_En = department.Name_En;
            return RedirectToView($"Details", model);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            var model = new Models.DepartmentViewModel
            {
                Id=0
            };
            return RedirectToView($"Create",model);
        }

        // POST: Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.DepartmentViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    var department = new Data.Department
                    {
                        Id = model.Id,
                        Name_Ar = model.Name_Ar,
                        Name_En = model.Name_En,
                    };

                    departmentRepo.Add(department);

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

        // GET: Department/Edit/3
        public ActionResult Edit(int id)
        {
            var department = departmentRepo.Find(id);

            var viewModel = new Models.DepartmentViewModel
            {
                Id = department.Id,
                Name_En = department.Name_En,
                Name_Ar = department.Name_Ar,
            };
            return RedirectToView($"Edit",viewModel);
        }

        // POST: Department/Edit/3
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.DepartmentViewModel viewModel)
        {
            try
            {
                // TODO: Add update logic here
                var department = new Data.Department
                {
                    Id = viewModel.Id,
                    Name_Ar = viewModel.Name_Ar,
                    Name_En = viewModel.Name_En,
                };

                departmentRepo.Update(viewModel.Id, department);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToView($"Edit", viewModel);
            }
        }

        // GET: Department/Delete/3
        public ActionResult Delete(int id)
        {
            var department = departmentRepo.Find(id);
            var model = new Models.DepartmentViewModel();
            model.Id = department.Id;
            model.Name_Ar = department.Name_Ar;
            model.Name_En = department.Name_En;
            return RedirectToView($"Delete", model);
        }

        // POST: Department/Delete/3
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            var model = new Models.DepartmentViewModel();
            model.Id = id;
            try
            {
                // TODO: Add delete logic here
                departmentRepo.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToView($"Delete", model);
            }
        }

    }
}
