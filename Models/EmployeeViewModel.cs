using HrSystem.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string First_Name_En { get; set; }
        [Required]
        public string First_Name_Ar { get; set; }
        [Required]
        public string Last_Name_En { get; set; }
        [Required]
        public string Last_Name_Ar { get; set; }
        public string Email { get; set; }
        [Required]
        public string Phone_Number { get; set; }
        public IFormFile File { get; set; }
        public string Img_Name { get; set; }
        public DateTime? Hire_Date { get; set; }
        public int? NationaltyId { get; set; }
        public int? StayingCountryId { get; set; }
        [Required]
        public string IdentityType { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        public DateTime? IdentityIssuDate { get; set; }
        public DateTime? IdentityExpiredDate { get; set; }
        public string IdentityIssuPlace { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string BirthPlace { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public IFormFile AttachFile { get; set; }
        public string AttachmentFile { get; set; }
        public DateTime? AddedDate { get; set; }
        public Guid? AddedUser { get; set; }
        public DateTime? EditedDate { get; set; }
        public Guid? EditedUser { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDate { get; set; }
        public Guid? DeletedUser { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public Country Nationality { get { return this.Countries?.Where(a => a.Id == this.NationaltyId)?.FirstOrDefault(); } }
        public Country Country { get { return this.Countries?.Where(a => a.Id == this.StayingCountryId)?.FirstOrDefault(); } }
        public City City { get { return this.Cities?.Where(a => a.Id == this.CityId)?.FirstOrDefault(); } }
        public List<Data.Employee> Employees { get; set; }
        public List<Data.Department> Departments { get; set; }
        public List<Data.Country> Countries { get; set; }
       // public List<Data.Country> Nationalities { get; set; }
        public List<Data.City> Cities { get; set; }
        public List<IdentityType> IdentityTypes { get; set; } = new List<IdentityType>
        {
            new IdentityType{Id="1",Name_Ar="هوية شحصية",Name_En="Idenity"},
            new IdentityType{Id="2",Name_Ar="جواز سفر",Name_En="Passport"},
            new IdentityType{Id="3",Name_Ar="بطاقة عائلية",Name_En="Family card"},
            new IdentityType{Id="4",Name_Ar="اقامة",Name_En="Residence ID"},
        };
        public List<BloodType> BloodTypes { get; set; } = new List<BloodType>
        {
            new BloodType{Id="O",Name="O"},
            new BloodType{Id="A",Name="A"},
            new BloodType{Id="B",Name="B"},
            new BloodType{Id="AB",Name="AB"},
        };
        public IdentityType IdentityTypeObject { get => this.IdentityTypes?.Where(a => a.Id == this.IdentityType)?.FirstOrDefault(); }
    }
    public class BloodType
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class IdentityType
    {
        public string Id { get; set; }
        public string Name_En { get; set; }
        public string Name_Ar { get; set; }
    }
}
