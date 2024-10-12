using HrSystem.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Controllers
{
    public class EmployeeController : BaseBasicController
    {
        private readonly Repositories.IEmployeeRepo employeeRepo;
        private readonly IDepartmentRepo departmentRepo;
        private readonly ICountyRepo countyRepo;
        private readonly ICityRepo cityRepo;
        private readonly UserManager<Data.ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EmployeeController(IEmployeeRepo employeeRepo, IDepartmentRepo departmentRepo, ICountyRepo countyRepo, ICityRepo cityRepo, UserManager<Data.ApplicationUser> userManager, IWebHostEnvironment hostingEnvironme)
        {
            this.employeeRepo = employeeRepo;
            this.departmentRepo = departmentRepo;
            this.countyRepo = countyRepo;
            this.cityRepo = cityRepo;
            _userManager = userManager;
            _hostingEnvironment = hostingEnvironme;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = new Models.EmployeeViewModel();
            var rtv = employeeRepo.List();
            model.Employees = rtv?.ToList();
            return RedirectToView($"Index", model);
        }
        Models.EmployeeViewModel GetEmpViewModel(Data.Employee employee)
        {
            return new Models.EmployeeViewModel
            {
                AddedDate=employee.AddedDate,
                AddedUser=employee.AddedUser,
                Address=employee.Address,
                AttachmentFile=employee.AttachmentFile,
                BirthOfDate=employee.BirthOfDate,
                BirthPlace=employee.BirthPlace,
                BloodType=employee.BloodType,
               // City=employee.City,
                CityId=employee.CityId,
                //Country=employee.Country,
                DeletedDate=employee.DeletedDate,
                DeletedUser=employee.DeletedUser,
                Department=employee.Department,
                DepartmentId=employee.DepartmentId,
                EditedDate=employee.EditedDate,
                EditedUser=employee.EditedUser,
                Email=employee.Email,
                Employees=null,
                First_Name_Ar=employee.First_Name_Ar,
                First_Name_En=employee.First_Name_En,
                Hire_Date=employee.Hire_Date,
                Id=employee.Id,
                IdentityExpiredDate=employee.IdentityExpiredDate,
                IdentityIssuDate=employee.IdentityIssuDate,
                IdentityIssuPlace=employee.IdentityIssuPlace,
                IdentityNumber=employee.IdentityNumber,
                IdentityType=employee.IdentityType,
                Img_Name=employee.Img_Name,
                IsDeleted=employee.IsDeleted,
                Last_Name_Ar=employee.Last_Name_Ar,
                Last_Name_En=employee.Last_Name_En,
               // Nationality=employee.Nationality,
                NationaltyId=employee.NationaltyId,
                Phone_Number=employee.Phone_Number,
                StayingCountryId=employee.StayingCountryId
            };
        }
        Data.Employee GetDataModel(Models.EmployeeViewModel employee)
        {
            return new Data.Employee
            {
                AddedDate = employee.AddedDate,
                AddedUser = employee.AddedUser,
                Address = employee.Address,
                AttachmentFile = employee.AttachmentFile,
                BirthOfDate = employee.BirthOfDate,
                BirthPlace = employee.BirthPlace,
                BloodType = employee.BloodType,
                City = employee.City,
                CityId = employee.CityId,
                Country = employee.Country,
                DeletedDate = employee.DeletedDate,
                DeletedUser = employee.DeletedUser,
                Department = employee.Department,
                DepartmentId = employee.DepartmentId,
                EditedDate = employee.EditedDate,
                EditedUser = employee.EditedUser,
                Email = employee.Email,
                First_Name_Ar = employee.First_Name_Ar,
                First_Name_En = employee.First_Name_En,
                Hire_Date = employee.Hire_Date,
                Id = employee.Id,
                IdentityExpiredDate = employee.IdentityExpiredDate,
                IdentityIssuDate = employee.IdentityIssuDate,
                IdentityIssuPlace = employee.IdentityIssuPlace,
                IdentityNumber = employee.IdentityNumber,
                IdentityType = employee.IdentityType,
                Img_Name = employee.Img_Name,
                IsDeleted = employee.IsDeleted,
                Last_Name_Ar = employee.Last_Name_Ar,
                Last_Name_En = employee.Last_Name_En,
                Nationality = employee.Nationality,
                NationaltyId = employee.NationaltyId,
                Phone_Number = employee.Phone_Number,
                StayingCountryId = employee.StayingCountryId
            };
        }
        // GET: Employee/Details/3
        public ActionResult Details(int id)
        {
            
            var employee = employeeRepo.Find(id);
            var model = GetEmpViewModel(employee);
            model.Departments = departmentRepo.List()?.ToList();
            model.Cities = cityRepo.List()?.ToList();
            model.Countries = countyRepo.List().ToList();
            return RedirectToView($"Details", model);
        }
        // GET: Employee/Create
        [Authorize]
        public ActionResult Create()
        {
            var model = new Models.EmployeeViewModel
            {
                Id = 0,
                Departments = departmentRepo.List()?.ToList(),
                Cities = cityRepo.List()?.ToList(),
                Countries = countyRepo.List().ToList()
                
            };
            return RedirectToView($"Create", model);
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Models.EmployeeViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var employee = GetDataModel(model);
                    employee.AddedDate = DateTime.Now;
                    employee.AddedUser = Guid.Parse(_userManager.GetUserId(User));
                    employee.Img_Name = SaveImage(model.File).Result;
                    employee.AttachmentFile = SaveFiles(model.AttachFile).Result;
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
       async Task<string> SaveImage(IFormFile imageFile)
        {
            var mediaFilesPath = Path.Combine(Directory.GetCurrentDirectory(), "MediaFiles","Employees","Images");
            if (!Directory.Exists(mediaFilesPath))
            {
                Directory.CreateDirectory(mediaFilesPath);
            }

            // Generate a unique file name
            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            //var fileName = Path.GetFileName(imageFile.FileName);
            var filePath = Path.Combine(mediaFilesPath, uniqueFileName);

            // Save the file
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
              await imageFile.CopyToAsync(stream);
            }
            return uniqueFileName;
        }
        async Task<string> SaveFiles(IFormFile file)
        {
            var mediaFilesPath = Path.Combine(Directory.GetCurrentDirectory(), "MediaFiles", "Employees", "Docs");
            if (!Directory.Exists(mediaFilesPath))
            {
                Directory.CreateDirectory(mediaFilesPath);
            }

            // Generate a unique file name
            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            //var fileName = Path.GetFileName(imageFile.FileName);
            var filePath = Path.Combine(mediaFilesPath, uniqueFileName);

            // Save the file
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return uniqueFileName;
        }
        async Task<string> UploadImage(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                // Generate a unique filename
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var mediaFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, "MediaFiles");

                // Create the directory if it doesn't exist
                if (!Directory.Exists(mediaFolderPath))
                {
                    Directory.CreateDirectory(mediaFolderPath);
                }

                // Save the file
                var filePath = Path.Combine(mediaFolderPath, uniqueFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return uniqueFileName;

            }
            return null;

        }
        // GET: Employee/Edit/3
        public ActionResult Edit(int id)
        {
            var employee = employeeRepo.Find(id);

            var viewModel = GetEmpViewModel(employee);
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
                var employee = GetDataModel(viewModel);
                employee.EditedDate = DateTime.Now;
                employee.EditedUser = Guid.Parse(_userManager.GetUserId(User));
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

        // Action to display PDF
        public IActionResult ViewPdf(string fileName)
        {
            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "pdfs", fileName);
            var mediaFilesPath = Path.Combine(Directory.GetCurrentDirectory(), "MediaFiles", "Employees", "Docs", fileName);
            
            if (!System.IO.File.Exists(mediaFilesPath))
            {
                return NotFound();
            }

            return File(mediaFilesPath, "application/pdf");
        }

        // Action to download PDF
        public IActionResult DownloadPdf(string fileName)
        {
           // string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "pdfs", fileName);
            var mediaFilesPath = Path.Combine(Directory.GetCurrentDirectory(), "MediaFiles", "Employees", "Docs", fileName);

            if (!System.IO.File.Exists(mediaFilesPath))
            {
                return NotFound();
            }

            return File(mediaFilesPath, "application/pdf", fileName);
        }

    }
}
