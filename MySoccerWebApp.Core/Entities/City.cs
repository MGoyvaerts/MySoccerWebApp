using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class City
    {
        #region Properties
        [Key]
        public int CityID { get; set; }
        [Required]
        [StringLength(50)]
        public string Cityname { get; set; }
        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public ICollection<Club> Clubs { get; set; }
        public Province Province { get; set; }
        #endregion
    }
}
