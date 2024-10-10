using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name_En { get; set; }
        [Required]
        public string Name_Ar { get; set; }
        public string Message { get; set; }
        public List<Data.Department> Departments { get; set; }
    }
}
