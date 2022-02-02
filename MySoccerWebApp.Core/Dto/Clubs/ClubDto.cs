using MySoccerWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Dto.Clubs
{
    public class ClubDto
    {
        #region Properties
        public int ClubID { get; set; }
        public string RootNumber { get; set; }
        public string ClubName { get; set; }
        public string Logo { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Website { get; set; }
        public int MatchesPlayed { get; set; }
        public int TotalPoints { get; set; }
        public int GamesWon { get; set; }
        public int GamesDraw { get; set; }
        public int GamesLost { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceeded { get; set; }
        public int GoalsDifference { get; set; }
        public int TotalYellowCards { get; set; }
        public int TotalRedCards { get; set; }
        public bool IsDeleted { get; set; }
        public City City { get; set; }
        public Division Division { get; set; }
        public Trainer Trainer { get; set; }
        #endregion
    }
}
