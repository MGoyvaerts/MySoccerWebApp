using MySoccerWebApp.Infrastructure.DatabaseContext;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Business.Domains
{
    public abstract class BaseBusinessDomain : IBaseBusinessDomain
    {
        #region Properties
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructors
        public BaseBusinessDomain()
        {
        }

        protected BaseBusinessDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion
    }
}
