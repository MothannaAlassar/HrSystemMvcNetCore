using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Data
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        public string CountryName_En { get; set; }
        public string CountryName_Ar { get; set; }
        public string Nationality_En { get; set; }
        public string Nationality_Ar { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
