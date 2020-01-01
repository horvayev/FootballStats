using Application.UseCases.CreateTeam;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<CreateTeamInput, Team>();
            CreateMap<Team, CreateTeamOutput>();
        }
    }
}
