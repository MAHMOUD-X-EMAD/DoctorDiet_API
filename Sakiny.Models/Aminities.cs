using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class Aminities: IBaseModel<int>
    {
        public int Id { get; set; }
        public bool WiFi { get; set; }
        public bool Cooker { get; set; }
        public bool Heater { get; set; }
        public bool TV { get; set; }
        public bool AirContidioner { get; set; }
        public bool Fridge { get; set; }
        public bool Banio { get; set; }
        public bool Disk { get; set; }
        public bool Office { get; set; }
        public bool Cupboard { get; set; }
        public bool WashingMachine { get; set; }

        [DefaultValue("false")]
        public bool IsDeleted { get; set; }

    }
}
