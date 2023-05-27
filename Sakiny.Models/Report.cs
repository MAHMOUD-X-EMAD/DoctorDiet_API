using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class Report :BaseModel
    {
        [ForeignKey("Apartment")]
        public int ApartmentId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public string IssueDescription { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public virtual Apartment Apartment { get; set; }
        
        public virtual User User { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }

    }
}
