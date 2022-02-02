using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class Contactperson
    {
        #region Properties
        [Key]
        public int ContactpersonID { get; set; }
        [Required]
        [StringLength(50)]
        public string ContactpersonFirstname { get; set; }
        [Required]
        [StringLength(50)]
        public string ContactpersonName { get; set; }
        [Required]
        [StringLength(50)]
        public string ContactpersonPhoneNumber { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public virtual Club Club { get; set; }
        #endregion
    }
}
