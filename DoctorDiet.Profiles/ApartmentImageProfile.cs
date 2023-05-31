using AutoMapper;
using Sakiny.DTO;
using Sakiny.Models;
using Sakiny.Models.Models_Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakiny.Profiles
{
  public class ApartmentImageProfile: Profile
  {
    public ApartmentImageProfile() {

      CreateMap<ApartmentImages, ApartmentImagesDTO>();

      CreateMap<ApartmentImagesDTO, ApartmentImages>();

    }

  }
}
