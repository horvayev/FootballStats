using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<EFDataAccess.Entities.Team, Domain.Entities.Team>(MemberList.None);
        }
    }
}
