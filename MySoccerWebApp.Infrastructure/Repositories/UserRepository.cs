using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Infrastructure.DatabaseContext;
using MySoccerWebApp.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region Constructors
        public UserRepository(MySoccerWebAppDbContext context) : base(context)
        {

        }
        #endregion

        #region Public Methods
        public User GetUserByEmail(string email)
        {
            return Context.Users.Where(u => u.Email == email).FirstOrDefault();
        }
        #endregion
    }
}
