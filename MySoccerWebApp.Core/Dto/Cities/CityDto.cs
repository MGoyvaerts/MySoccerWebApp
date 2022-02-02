using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Dto.Cities
{
    public class CityDto
    {
        public int CityID { get; set; }
        public string Cityname { get; set; }
        public string ZipCode { get; set; }
        public Province Province { get; set; }
        public ICollection<Club> Clubs { get; set; }
    }
}
