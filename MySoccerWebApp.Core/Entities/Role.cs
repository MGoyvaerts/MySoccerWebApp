using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Entities
{
    public class Role
    {
        #region Properties
        [Key]
        public int RoleID { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }
        #endregion

        #region Relations
        public ICollection<UserRole> UserRoles { get; set; }
        #endregion
    }
}
