using Application.UseCases.CreateTeam;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Controllers.CreateTeam;

namespace WebApi.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<CreateTeamRequest, CreateTeamInput>();
        }
    }
}
