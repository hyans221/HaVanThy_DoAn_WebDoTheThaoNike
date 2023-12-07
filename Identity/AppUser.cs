using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HaVanThy_DoAn_WebDoTheThaoNike.Identity
{
    public class AppUser : IdentityUser
    {
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}