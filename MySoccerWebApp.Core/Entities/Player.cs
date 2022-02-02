using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class Player
    {
        #region Properties
        [Key]
        public int PlayerID { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Goals { get; set; }
        public int MinutesPlayed { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public Club Club { get; set; }
        public PlayerPosition Position { get; set; }
        #endregion
    }
}
