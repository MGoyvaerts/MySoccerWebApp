using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySoccerWebApp.Core.Dto.Users
{
    public class RegisterUserDto
    {
        #region Properties
        [Required(ErrorMessage = "Gelieve je voornaam in te geven")]
        [StringLength(50, ErrorMessage = "Gelieve je voornaam in te geven")]
        [Display(Name="Voornaam")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Gelieve je naam in te geven")]
        [StringLength(50, ErrorMessage = "Gelieve je naam in te geven")]
        [Display(Name = "Naam")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Gelieve je mailadres in te geven")]
        [StringLength(50, ErrorMessage = "Gelieve je mailadres in te geven")]
        [Display(Name = "E-mailadres")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gelieve je wachtwoord in te geven")]
        [StringLength(20, ErrorMessage = "Gelieve je wachtwoord in te geven")]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Gelieve je wachtwoord te bevestigen")]
        [StringLength(20, ErrorMessage = "Gelieve je wachtwoord te bevestigen")]
        [Display(Name = "Wachtwoord bevestigen")]
        public string PasswordConfirmation { get; set; }
        #endregion
    }
}
