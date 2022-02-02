using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class Trainer
    {
        #region Properties
        [Key]
        public int TrainerID { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime Birthday { get; set; }
        [Required]
        public bool IsCurrentClub { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public virtual Club Club { get; set; }
        #endregion
    }
}
