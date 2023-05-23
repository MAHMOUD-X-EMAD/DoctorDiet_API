using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }
    }
}
