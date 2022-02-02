using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Infrastructure.DatabaseContext;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Infrastructure.Repositories
{
    public class ClubRepository : BaseRepository<Club>, IClubRepository
    {
        #region Constructors
        public ClubRepository(MySoccerWebAppDbContext context) : base(context)
        {

        }
        #endregion

        #region Methods
        public IQueryable<Club> GetAllClubs()
        {
            return Context.Clubs;
        }
        #endregion
    }
}
