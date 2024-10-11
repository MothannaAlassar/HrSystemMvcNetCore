using HrSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public interface ICountyRepo
    {
        IList<Country> List();
        Country Find(int id);
        void Add(Country entity);
        void Update(int id, Country entity);
        void Delete(int id);
        List<Country> Search(string term);
    }
}
