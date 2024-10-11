using HrSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public interface ICityRepo
    {
        IList<City> List();
        City Find(int id);
        void Add(City entity);
        void Update(int id, City entity);
        void Delete(int id);
        List<City> Search(string term);
    }
}
