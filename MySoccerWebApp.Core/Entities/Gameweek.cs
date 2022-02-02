using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Entities
{
    public class Gameweek
    {
        #region Properties
        [Key]
        public int GameweekID { get; set; }
        [Required]
        [StringLength(2)]
        public string GameweekNumber { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public  Club AwayTeam { get; set; }
        public  Club HomeTeam { get; set; }
        public Season Season { get; set; }
        #endregion
    }
}
