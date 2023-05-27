using Sakiny.Models.Models_Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models
{
    public class Menu//: BaseModel
    {
        public int Id { get; set; }
        public virtual List<Meals> Meals { get; set; }
        public virtual List<MenuImages> Images { get; set; }

      
    }
}
