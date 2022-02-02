using AutoMapper;
using MySoccerWebApp.Core.Dto.Clubs;
using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Infrastructure.Mapper
{
    public class ClubMappingProfile : Profile
    {
        #region Methods
        public ClubMappingProfile()
        {
            CreateMap<Club, ClubDto>()
                //.ForMember(dest => dest.TotalPoints, opt => opt.MapFrom(src => src.GamesWon * 3 + src.GamesDraw - 1))
                //.ForMember(dest => dest.GoalsDifference, opt => opt.MapFrom(src => src.GoalsScored - src.GoalsConceeded))
                .ReverseMap();
        }
        #endregion
    }
}
