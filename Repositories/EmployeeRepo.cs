using HrSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public class EmployeeRepo : IEmployeeRepo
    {

        private readonly Data.ApplicationDbContext dbContext;
        public EmployeeRepo(Data.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Employee entity)
        {
            dbContext.Employees.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = Find(id);

            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
        }

        public Employee Find(int id)
        {
            var book = dbContext.Employees.Include(a => a.Department).SingleOrDefault(b => b.Id == id);

            return book;
        }

        public IList<Employee> List()
        {
            return dbContext.Employees.Include(a => a.Department).ToList();
        }

        public void Update(int id, Employee employee)
        {
           // var emp = Find(id);
            
            dbContext.Update(employee);
            dbContext.SaveChanges();
        }

        public List<Employee> Search(string term)
        {
            var result = dbContext.Employees.Include(a => a.Department)
                .Where(b => b.First_Name_En.Contains(term)
                || b.First_Name_Ar.Contains(term)
                        ).ToList();

            return result;
        }
    }
}
