using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Interfaces.Domains
{
    public interface IUserDomain : IBaseBusinessDomain
    {
        #region Methods
        User GetUserByEmail(string email);
        void CreateUser(User user);
        bool ValidateUser(string email, string password);
        void UpdateUserLoginStatus(User user);
        #endregion
    }
}
