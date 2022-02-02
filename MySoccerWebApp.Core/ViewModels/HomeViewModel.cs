using MySoccerWebApp.Core.Dto.Clubs;
using MySoccerWebApp.Core.Dto.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.ViewModels
{
    public class HomeViewModel
    {
        #region properties
        public List<ClubDto> Clubs { get; set; }
        public UserDto User { get; set; }
        #endregion

        #region Constructors

        #endregion
    }
}
