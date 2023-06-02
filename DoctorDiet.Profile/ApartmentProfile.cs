//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sakiny.Profiles
//{
//    public class ApartmentProfile: Profile
//    {
//        public ApartmentProfile() {
//      CreateMap<Apartment, ApartmentDTO>()
//          .ForMember(dst => dst.Ownerfirstname, opt =>
//              opt.MapFrom(src => src.Owner.ApplicationUser.FirstName))
//          .ForMember(dst => dst.OwnerPhone, opt =>
//              opt.MapFrom(src => src.Owner.ApplicationUser.PhoneNumber))
//          .ForMember(dst => dst.Ownerlastname, opt =>
//              opt.MapFrom(src => src.Owner.ApplicationUser.LastName));
                


//      CreateMap<ApartmentPostDTO,Apartment>()
//        .ForMember(dst => dst.ApartmentImages, opt =>
//                    opt.Ignore());
//      CreateMap<Apartment, ApartmentPostDTO>();
        



//    }

//  }
//}
