using AutoMapper;
using MySoccerWebApp.Core.Dto.Cities;
using MySoccerWebApp.Core.Entities;

namespace MySoccerWebApp.Mapping.Profiles
{
    public class CityMappingProfile : Profile
    {
        #region Constructor
        public CityMappingProfile()
        {
            CreateMap<City, CityDto>().ReverseMap();
        }
        #endregion
    }
}
