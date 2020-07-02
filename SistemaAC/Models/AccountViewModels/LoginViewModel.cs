using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ACTI.Models.AccountViewModels
{
    public class  LoginViewModel
    {
        [Required(ErrorMessage = "El campo email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo correo electrónico no es una dirección de correo electrónico válida.")]
        public  string Email { get; set; }

        [Required(ErrorMessage = "El campo Password es obligatorio.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "¿Recordarme?")]
        public bool RememberMe { get; set; }
    }
}
