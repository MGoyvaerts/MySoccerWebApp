using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Entities
{
    public class Season
    {
        #region Properties
        [Key]
        public int SeasonID { get; set; }
        [Required]
        [StringLength(10)]
        public string SeasonYear { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        #region Relations
        public ICollection<Gameweek> Gameweeks { get; set; }
        #endregion
    }
}
