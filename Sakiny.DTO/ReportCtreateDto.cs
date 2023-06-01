using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.DTO
{
    public class ReportCtreateDto
    {
        public int ApartmentId { get; set; }
        public string UserId { get; set; }
        public string IssueDescription { get; set; }

    }
}
