using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HrSystem.Data
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Id { get; set; }
        public string CityName_En { get; set; }
        public string CityName_Ar { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}
