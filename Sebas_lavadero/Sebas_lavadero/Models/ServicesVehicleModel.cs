using Microsoft.AspNetCore.Mvc.Rendering;
using Sebas_lavadero.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace Sebas_lavadero.Models
{
    public class ServicesVehicleModel : Entity
    {
        [Display(Name = "Propietari")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Owner { get; set; }

        [Display(Name = "numero de placa")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Plate { get; set; }

        [Display(Name = "Servicio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid ServicesId { get; set; }

        public IEnumerable<SelectListItem> Services { get; set; }
    }
}
