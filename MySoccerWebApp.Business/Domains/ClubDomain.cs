using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Domains;
using MySoccerWebApp.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Business.Domains
{
    public class ClubDomain : IClubDomain
    {
        #region Properties
        private readonly IClubRepository _clubRepository;
        #endregion

        #region Constructor
        public ClubDomain(IUnitOfWork unitOfWork, IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        #endregion

        #region Methods
        public IEnumerable<Club> GetAllClubs()
        {
            return _clubRepository.GetAllClubs();
        }
        #endregion
    }
}
