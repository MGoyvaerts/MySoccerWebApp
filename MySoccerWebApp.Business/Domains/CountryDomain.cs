using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Infrastructure.UnitOfWork;
using MySoccerWebApp.Interfaces.Domains;
using MySoccerWebApp.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MySoccerWebApp.Business.Domains
{
    public class CountryDomain : BaseBusinessDomain, ICountryDomain
    {
        #region Properties
        private readonly ICountryRepository _countryRepository;
        #endregion

        #region Constructors
        public CountryDomain(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            :base(unitOfWork)
        {
            _countryRepository = countryRepository;
        }
        #endregion

        #region Methods
        public IEnumerable<Country> GetAllCountries()
        {
            return _countryRepository.GetAllCountries();
        }
        public Country GetCountryById(int countryId)
        {
            return _countryRepository.GetCountryById(countryId);
        }
        #endregion
    }
}
