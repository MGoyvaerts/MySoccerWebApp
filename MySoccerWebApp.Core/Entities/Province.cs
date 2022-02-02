using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MySoccerWebApp.Core.Entities
{
    public class Province
    {
        #region Properties
        [Key]
        public int ProvinceID { get; set; }
        [Required]
        [StringLength(50)]
        public string Provincename { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Division> Divisions { get; set; }
        #endregion
    }
}
