using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Dto.Users
{
    public class LoginUserDto
    {
        #region Properties
        [Required(ErrorMessageResourceType = typeof(Resources.Translation), ErrorMessageResourceName = "EmailaddressRequiredErrorMessage")]
        [StringLength(50)]
        //[Display(ResourceType = typeof(Resources.Translation), Name = nameof(Resources.Translation.Email))]
        public string Email { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Translation), ErrorMessageResourceName = "PasswordRequiredErrorMessage")]
        [StringLength(20)]
        //[Display(ResourceType = typeof(Resources.Translation), Name = nameof(Resources.Translation.Password))]
        public string Password { get; set; }
        public string ValidLogin { get; set; }
        #endregion
    }
}
