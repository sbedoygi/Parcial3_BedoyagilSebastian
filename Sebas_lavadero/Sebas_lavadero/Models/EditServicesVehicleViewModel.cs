using Sebas_lavadero.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace Sebas_lavadero.Models
{
    public class EditServicesVehicleViewModel : Entity
    {
        [Display(Name = "Propietario")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Owner { get; set; }

        [Display(Name = "Número de Placa")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Plate { get; set; }
    }
}
