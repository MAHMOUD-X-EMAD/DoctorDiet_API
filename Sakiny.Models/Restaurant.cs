using Sakiny.Models.Models_Images;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sakiny.Models
{
    public class Restaurant//: BaseModel
    {
         public int Id { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public string LogoImage { get; set; }
        public List<MenuImages> MenuImage { get; set; }
        public virtual Address Address { get; set; }

      

    }
}