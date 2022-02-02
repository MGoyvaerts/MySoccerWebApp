using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Interfaces.Repositories
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        #region Methods
        IQueryable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
        #endregion
    }
}
