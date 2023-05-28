using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Models.Models_Images
{
    public class ApartmentImages: IBaseModel<int>
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string URL { get; set; }

        [ForeignKey("Apartment")]
        public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }

  }
}
