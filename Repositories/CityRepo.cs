using HrSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Repositories
{
    public class CityRepo:ICityRepo
    {
        private readonly Data.ApplicationDbContext dbContext;
        public CityRepo(Data.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        /// <summary>
        /// add new city
        /// </summary>
        /// <param name="entity"></param>
        public void Add(City entity)
        {
            var mx = dbContext.Cities.Max(a => a.Id);
            if (mx == 0)
                mx = 1;
            else
                mx = mx + 1;
            entity.Id = mx;
            dbContext.Cities.Add(entity);
            dbContext.SaveChanges();
        }
        /// <summary>
        /// this function for delete the city
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var city = Find(id);

            dbContext.Cities.Remove(city);
            dbContext.SaveChanges();
        }
        /// <summary>
        /// find the city by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public City Find(int id)
        {
            var country = dbContext.Cities.Include(a => a.Country).SingleOrDefault(b => b.Id == id);

            return country;
        }
        /// <summary>
        /// this function for retrive all cities
        /// </summary>
        /// <returns></returns>
        public IList<City> List()
        {
            return dbContext.Cities.Include(a => a.Country).ToList();
        }
        /// <summary>
        /// this function for update the current city
        /// </summary>
        /// <param name="id"></param>
        /// <param name="city"></param>
        public void Update(int id, City city)
        {
            dbContext.Update(city);
            dbContext.SaveChanges();
        }
        /// <summary>
        /// this function to retrive cities based on term parameter
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public List<City> Search(string term)
        {
            var result = dbContext.Cities.Include(a => a.Country)
                .Where(b => b.CityName_En.Contains(term)
                || b.CityName_Ar.Contains(term)
                        ).ToList();

            return result;
        }
    }
}
