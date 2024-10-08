using HrSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public interface  IEmployeeRepo
    {
        IList<Employee> List();
        Employee Find(int id);
        void Add(Employee entity);
        void Update(int id, Employee entity);
        void Delete(int id);
        List<Employee> Search(string term);
    }
}
