using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.DTO
{
  public class ApartmentImagesDTO
  {
    public bool IsDeleted { get; set; }
    public string URL { get; set; }
    public int ApartmentId { get; set; }
  }
}
