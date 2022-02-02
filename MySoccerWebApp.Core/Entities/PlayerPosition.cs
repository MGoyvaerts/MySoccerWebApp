using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class PlayerPosition
    {
        #region Properties
        [Key]
        public int PositionID { get; set; }
        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        [Required]
        [StringLength(2)]
        public string PositionNumber { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public ICollection<Player> Players { get; set; }
        #endregion
    }
}
