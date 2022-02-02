using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Dto.Countries
{
    public class CountryDto
    {
        #region Properties
        public string CountryName { get; set; }
        public string CountryIsoCode { get; set; }
        public ICollection<Province> Provinces { get; set; }
        #endregion

    }
}
