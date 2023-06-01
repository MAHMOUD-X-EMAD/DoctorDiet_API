using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.DTO
{
    public class ReportDto
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string UserId { get; set; }
        public string IssueDescription { get; set; }
    }
}
