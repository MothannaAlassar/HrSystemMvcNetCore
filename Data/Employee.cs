using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name_En { get; set; }
        public string Name_Ar { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
