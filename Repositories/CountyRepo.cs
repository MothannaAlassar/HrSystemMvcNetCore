using HrSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public class CountyRepo: ICountyRepo
    {
        private readonly Data.ApplicationDbContext dbContext;
        public CountyRepo(Data.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Country entity)
        {
            var mx = dbContext.Countries.Max(a => a.Id);
            if (mx == 0)
                mx = 1;
            else
                mx = mx + 1;
            entity.Id = mx;
            dbContext.Countries.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var country = Find(id);

            dbContext.Countries.Remove(country);
            dbContext.SaveChanges();
        }
        /// <summary>
        /// find the country by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Country Find(int id)
        {
            var country = dbContext.Countries.Include(a => a.Cities).SingleOrDefault(b => b.Id == id);

            return country;
        }

        public IList<Country> List()
        {
            return dbContext.Countries.Include(a => a.Cities).ToList();
        }

        public void Update(int id, Country country)
        {
            dbContext.Update(country);
            dbContext.SaveChanges();
        }

        public List<Country> Search(string term)
        {
            var result = dbContext.Countries.Include(a => a.Cities)
                .Where(b => b.CountryName_En.Contains(term)
                || b.CountryName_Ar.Contains(term)
                || b.Nationality_En.Contains(term)
                || b.Nationality_Ar.Contains(term)
                        ).ToList();

            return result;
        }
    }
}
