using HrSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public interface IDepartmentRepo
    {
        IList<Department> List();
        Department Find(int id);
        void Add(Department entity);
        void Update(int id, Department entity);
        void Delete(int id);
        List<Department> Search(string term);
    }
}
