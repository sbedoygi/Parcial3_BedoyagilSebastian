using System.ComponentModel.DataAnnotations;

namespace Sebas_lavadero.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "por favor ingresar un correo válido")]
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MinLength(6, ErrorMessage = "This field {0} must be have at least {1} characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Recordarme en este navegador Siempre.")]
        public bool RememberMe { get; set; }
    }
}
