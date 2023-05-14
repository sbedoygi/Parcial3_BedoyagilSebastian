using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Sebas_lavadero.Models
{
    public class AddServicesVehicleViewModel : EditServicesVehicleViewModel
    {
        [Display(Name = "Servicios")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid ServiceId { get; set; }
        public IEnumerable<SelectListItem> Services { get; set; }
    }
}
