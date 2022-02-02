using MySoccerWebApp.Core.Entities;
using MySoccerWebApp.Infrastructure.DatabaseContext;
using MySoccerWebApp.Interfaces.Repositories;
using System.Data.Entity;
using System.Linq;

namespace MySoccerWebApp.Infrastructure.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        #region Constructors
        public CountryRepository(MySoccerWebAppDbContext dbContext)
            : base(dbContext)
        {

        }
        #endregion

        #region Methods
        public IQueryable<Country> GetAllCountries()
{
            return Context.Countries;

        }

        public Country GetCountryById(int countryId)
        {
            return Context.Countries.Where(c => c.CountryID == countryId).FirstOrDefault();
        }

        #endregion


    }
}
