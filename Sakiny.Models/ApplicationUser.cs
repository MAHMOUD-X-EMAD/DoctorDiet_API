using Microsoft.AspNetCore.Identity;
using Sakiny.Models.Models_Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string ContactInfo { get; set; }

        public string ProfileImage { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
