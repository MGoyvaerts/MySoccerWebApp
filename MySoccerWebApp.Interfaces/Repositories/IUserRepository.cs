using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        #region Public Methods
        User GetUserByEmail(string email);
        #endregion
    }
}
