using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<Department> Departments { get; set; }
       public DbSet<Employee> Employees { get; set; }
       public DbSet<ApplicationUser> ApplicationUsers { get; set; }
       public DbSet<Country> Countries { get; set; }
       public DbSet<City> Cities { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>()
           .HasKey(c => c.Id);
            builder.Entity<City>()
          .HasKey(c => c.Id);
            builder.Entity<Country>().HasData(
                new Country { Id=1, CountryName_En = "United Arab Emarites",CountryName_Ar="الامارات العربية المتحدة", Nationality_En = "Emarati",Nationality_Ar="اماراتي" },
                new Country {Id=2, CountryName_En = "Sudia",CountryName_Ar="المملكة العربية السعودية", Nationality_En = "sudi",Nationality_Ar="سعودي" }
                );
            builder.Entity<City>().HasData(
                new City {Id=1, CityName_En = "Dubai",CityName_Ar="دبي", CountryId = 1 },
                new City {Id=2, CityName_En = "AbuDhabi",CityName_Ar="ابو ظبي", CountryId = 1 },
                new City {Id=3, CityName_En = "sharja",CityName_Ar="الشارقة", CountryId = 1 },
                new City {Id=4, CityName_En = "Ajman",CityName_Ar="عجمان", CountryId = 1 },
                new City {Id=5, CityName_En = "RAK",CityName_Ar="راس الخيمة", CountryId = 1 }
                );
        }
    }
}
