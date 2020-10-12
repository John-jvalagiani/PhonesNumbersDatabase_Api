using Aplication.Core.Entities;
using AutoMapper;
using Server.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Profiles
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<PhoneNumber, PhonenumbersWrite>();
            CreateMap<PhonenumbersWrite, PhoneNumber>();

            CreateMap<ICollection<PhonenumbersWrite>, ICollection<PhoneNumber>>();
            CreateMap<ICollection<PhoneNumber>, ICollection<PhonenumbersWrite>>();




        }

    }
}
