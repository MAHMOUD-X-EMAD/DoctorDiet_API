using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sakiny.Models.Models_Images;

namespace Sakiny.Models
{
    public class Owner:IBaseModel<string>
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public OwnerImages IdentityImage { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
