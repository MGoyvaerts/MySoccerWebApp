using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoccerWebApp.Core.Entities
{
    public class Club
    {
        #region Properties
        [Key]
        public int ClubID { get; set; }
        [StringLength(10)]
        public string RootNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string ClubName { get; set; }
        //[Required]
        [StringLength(100)]
        public string Logo { get; set; }
        [Required]
        [StringLength(50)]
        public string Street { get; set; }
        [StringLength(10)]
        public string Number { get; set; }
        [StringLength(1000)]
        public string Website { get; set; }
        [Required]
        public int TotalPoints { get; set; }
        [Required]
        public int MatchesPlayed { get; set; }
        [Required]
        public int GamesWon { get; set; }
        [Required]
        public int GamesDraw { get; set; }
        [Required]
        public int GamesLost { get; set; }
        [Required]
        public int GoalsScored { get; set; }
        [Required]
        public int GoalsConceeded { get; set; }
        [Required]
        public int GoalDifference { get; set; }
        [Required]
        public int TotalYellowCards { get; set; }
        [Required]
        public int TotalRedCards { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public City City { get; set; }
        //public virtual Contactperson ContactPerson { get; set; }
        public Division Division { get; set; }
        //public ICollection<Gameweek> Gameweeks { get; set; }
        public Trainer Trainer { get; set; }
        //public ICollection<Player> Players { get; set; }
        #endregion
    }
}
