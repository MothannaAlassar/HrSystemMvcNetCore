using HrSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public class DepartmentRepo:IDepartmentRepo
    {
        private readonly Data.ApplicationDbContext dbContext;
        public DepartmentRepo(Data.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Department entity)
        {
            dbContext.Departments.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = Find(id);

            dbContext.Departments.Remove(department);
            dbContext.SaveChanges();
        }

        public Department Find(int id)
        {
            var book = dbContext.Departments.Include(a => a.Employees).SingleOrDefault(b => b.Id == id);

            return book;
        }

        public IList<Department> List()
        {
            return dbContext.Departments.Include(a => a.Employees).ToList();
        }

        public void Update(int id, Department department)
        {
            dbContext.Update(department);
            dbContext.SaveChanges();
        }

        public List<Department> Search(string term)
        {
            var result = dbContext.Departments.Include(a => a.Employees)
                .Where(b => b.Name_En.Contains(term)
                || b.Name_Ar.Contains(term)
                        ).ToList();

            return result;
        }
    }
}
