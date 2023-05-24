using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sakiny.Models.Models_Images;

namespace Sakiny.Models
{
    public class Apartment: BaseModel
    {
       
        [ForeignKey("Owner")]
        public string OwnerId { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        [ForeignKey("Aminities")]
        public int AminitiesId { get; set; }
        public int numOfRooms { get; set; }
        public int numOfBeds { get; set; }
        public int Size { get; set; }
        public int RentAmount { get; set; }
        public bool Availability { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public int numOfAvailableBeds { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Aminities Aminities { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Address Address { get; set; }
        public virtual List<ApartmentImages> ApartmentImages { get; set; }
      
    }
}
