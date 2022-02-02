using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class Country
    {
        #region Properties
        [Key]
        public int CountryID { get; set; }
        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }
        [Required]
        [StringLength(2)]
        public string CountryIsoCode { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public ICollection<Province> Provinces { get; set; }
        #endregion
    }
}
