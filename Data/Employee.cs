using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string First_Name_En { get; set; }
        public string First_Name_Ar { get; set; }
        public string Last_Name_En { get; set; }
        public string Last_Name_Ar { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Img_Name { get; set; }
        public DateTime? Hire_Date { get; set; }
        public DateTime? AddedDate { get; set; }
        public Guid? AddedUser { get; set; }
        public DateTime? EditedDate { get; set; }
        public Guid? EditedUser { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDate { get; set; }
        public Guid? DeletedUser { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
