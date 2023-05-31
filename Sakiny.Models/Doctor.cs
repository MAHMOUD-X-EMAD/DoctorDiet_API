using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sakiny.Models.Interface;

namespace Sakiny.Models
{
    public class Doctor:IBaseModel<string>
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }

        public byte[] Image { get; set; }

        public virtual List<Plan> Plan { get; set; }

      public virtual List<Patient> Patients { get; set; }

        

    }
}