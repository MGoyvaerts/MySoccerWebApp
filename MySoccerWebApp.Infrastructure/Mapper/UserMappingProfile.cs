using AutoMapper;
using MySoccerWebApp.Core.Dto.Users;
using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Infrastructure.Mapper
{
    public class UserMappingProfile : Profile
    {
        #region Methods
        public UserMappingProfile()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();
            CreateMap<User, RegisterUserDto>()
                .ReverseMap();
            CreateMap<User, LoginUserDto>()
                .ReverseMap();
        }
        #endregion
    }
}
