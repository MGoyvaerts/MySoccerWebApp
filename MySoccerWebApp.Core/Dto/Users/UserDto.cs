using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Dto.Users
{
    public class UserDto
    {
        #region Properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public Boolean LoggedIn { get; set; }
        #endregion
    }
}
