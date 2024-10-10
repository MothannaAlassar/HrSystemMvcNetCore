using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HrSystem.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string Full_UserName_En { get; set; }
        public string Full_UserName_Ar { get; set; }
    }
}
