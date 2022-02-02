using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MySoccerWebApp.Core.Entities
{
    public class Division
    {
        #region Properties
        [Key]
        public int DivisionID { get; set; }
        [Required]
        [StringLength(50)]
        public string DivisionName { get; set; }
        public bool IsNational { get; set; }
        public bool IsProvincial { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public ICollection<Club> Clubs { get; set; }
        public virtual Country Country { get; set; }
        public Province Province { get; set; }
        #endregion
    }
}
