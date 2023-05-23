using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class Address: BaseModel
    {
        
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
       
    }
}
