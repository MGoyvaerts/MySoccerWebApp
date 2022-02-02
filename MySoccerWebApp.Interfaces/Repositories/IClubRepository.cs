using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Interfaces.Repositories
{
    public interface IClubRepository : IBaseRepository<Club>
    {
        #region Methods
        IQueryable<Club> GetAllClubs();
        #endregion
    }
}
