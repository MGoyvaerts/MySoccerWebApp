using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Entities
{
    public class UserRole
    {
        #region Properties
        [Key]
        public int UserRoleID { get; set; }
        #endregion

        #region Relations
        public Role Role { get; set; }
        public User User { get; set; }
        #endregion
    }
}
