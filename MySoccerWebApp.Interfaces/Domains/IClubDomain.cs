using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Interfaces.Domains
{
    public interface IClubDomain : IBaseBusinessDomain
    {
        #region MyRegion
        IEnumerable<Club> GetAllClubs();
        #endregion
    }
}
